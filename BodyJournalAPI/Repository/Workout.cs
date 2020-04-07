using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;

namespace BodyJournalAPI.Repository
{
  public class WorkoutRepository : RepositoryBase<Workout>,
  IWorkoutRepository
  {
    public WorkoutRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public Workout GetWorkout(int id)
    {
      return FindByCondition(entry => entry.Id == id).SingleOrDefault();
    }

    public IQueryable<Workout> GetWorkouts()
    {
      return FindAll();
    }

    public void CreateWorkout(Workout model)
    {
      Create(model);
    }

    public void UpdateWorkout(int id, Workout update)
    {
      var model = GetWorkout(id);
      if (model == null)
        throw new System.Exception($"No Workout");
      Update(update);
    }

    public void DeleteWorkout(int id)
    {
      var model = GetWorkout(id);
      if (model != null)
        Delete(model);
    }
  }
}