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
      Workout model = FindByCondition(entry => entry.Id == id).SingleOrDefault();

      IEnumerable<ExerciseWorkout> exerciseWorkouts = this.BodyJournalContext.ExerciseWorkouts.Where(entry => entry.WorkoutId == id);

      IEnumerable<Exercise> exercises = (from e in this.BodyJournalContext.Exercises join ew in exerciseWorkouts on e.Id equals ew.ExerciseId select e);

      return model;
    }
    public IQueryable<Workout> GetAllWorkoutsForUser(int id)
    {
      return FindByCondition(entry => entry.UserId == id);
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