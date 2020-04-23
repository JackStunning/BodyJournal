using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BodyJournalAPI.Repository
{
  public class WorkoutRepository : RepositoryBase<Workout>,
  IWorkoutRepository
  {
    public WorkoutRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }
    public async Task<Workout> GetWorkoutAsync(int id)
    {
      Workout model = await FindByCondition(entry => entry.Id == id).SingleOrDefaultAsync();

      IEnumerable<ExerciseWorkout> exerciseWorkouts = await this.BodyJournalContext.ExerciseWorkouts.Where(entry => entry.WorkoutId == id).ToListAsync();

      IEnumerable<Exercise> exercises = await (from e in this.BodyJournalContext.Exercises join ew in exerciseWorkouts on e.Id equals ew.ExerciseId select e).ToListAsync();

      return model;
    }
    public async Task<IEnumerable<Workout>> GetWorkoutsAsync(int id)
    {
      return await FindByCondition(entry => entry.UserId == id).ToListAsync();
    }

    public void CreateWorkout(Workout model)
    {
      Create(model);
    }

    public void UpdateWorkout(int id, Workout update)
    {
      var model = GetWorkoutAsync(id);
      if (model == null)
        throw new System.Exception($"No Workout");
      Update(update);
    }

    public async void DeleteWorkout(int id)
    {
      Workout model = await GetWorkoutAsync(id);
      if (model != null)
        Delete(model);
    }
  }
}