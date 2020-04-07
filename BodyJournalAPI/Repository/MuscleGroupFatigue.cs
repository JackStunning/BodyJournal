using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;

namespace BodyJournalAPI.Repository
{
  public class MuscleGroupFatigueRepository : RepositoryBase<MuscleGroupFatigue>,
  IMuscleGroupFatigueRepository
  {
    public MuscleGroupFatigueRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public MuscleGroupFatigue GetMuscleGroupFatigue(int id)
    {
      return FindByCondition(entry => entry.Id == id).SingleOrDefault();
    }

    public IQueryable<MuscleGroupFatigue> GetMuscleGroupFatigues()
    {
      return FindAll();
    }

    public void CreateMuscleGroupFatigue(MuscleGroupFatigue model)
    {
      Create(model);
    }

    public void UpdateMuscleGroupFatigue(int id, MuscleGroupFatigue update)
    {
      var model = GetMuscleGroupFatigue(id);
      if (model == null)
        throw new System.Exception($"No MuscleGroupFatigue");
      Update(update);
    }

    public void DeleteMuscleGroupFatigue(int id)
    {
      var model = GetMuscleGroupFatigue(id);
      if (model != null)
        Delete(model);
    }
  }
}