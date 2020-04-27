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
      Workout model = await FindByCondition(x => x.Id == id).
      SingleOrDefaultAsync();

      return model;
    }
    public async Task<IEnumerable<Workout>> GetWorkoutsAsync(int id)
    {
      return await FindByCondition(x => x.UserId == id).OrderBy(x => x.Name).ToListAsync();
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