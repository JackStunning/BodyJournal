using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;

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
      IQueryable<ExerciseWorkout> exerciseWorkout = this.BodyJournalContext.ExerciseWorkouts.Where(entry => entry.WorkoutId == id);

      IQueryable<Exercise> exercises = (from e in this.BodyJournalContext.Exercises join ew in exerciseWorkout on e.Id equals ew.ExerciseId select e);

      Workout w = FindByCondition(x => x.Id == id).SingleOrDefault();
      int inten = 0;
      foreach (Exercise item in exercises)
      {
        inten += item.Intensity;
      }
      w.IntensityScore = inten;

      return w;
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