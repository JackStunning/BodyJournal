using BodyJournalAPI.Entities;
using System.Linq;

namespace BodyJournalAPI.Contracts
{
  public interface ISessionRepository : IRepositoryBase<Session>
  {
    Session GetSession(int id);
    IQueryable<Session> GetSessions();
    void CreateSession(Session model);
    void UpdateSession(int id, Session model);
    void DeleteSession(int id);
  }
}