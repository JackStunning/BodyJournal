using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;

namespace BodyJournalAPI.Repository
{
  public class SessionRepository : RepositoryBase<Session>,
  ISessionRepository
  {
    public SessionRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public Session GetSession(int id)
    {
      return FindByCondition(entry => entry.Id == id).SingleOrDefault();
    }

    public IQueryable<Session> GetSessions()
    {
      return FindAll();
    }

    public void CreateSession(Session model)
    {
      Create(model);
    }

    public void UpdateSession(int id, Session update)
    {
      var model = GetSession(id);
      if (model == null)
        throw new System.Exception($"No Session");
      Update(update);
    }

    public void DeleteSession(int id)
    {
      var model = GetSession(id);
      if (model != null)
        Delete(model);
    }
  }
}