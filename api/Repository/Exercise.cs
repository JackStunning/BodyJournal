using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BodyJournalAPI.Repository
{
  public class ExerciseRepository : RepositoryBase<Exercise>,
  IExerciseRepository
  {
    public ExerciseRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }

    public async Task<Exercise> GetExerciseAsync(int id)
    {
      return await FindByCondition(entry => entry.Id == id).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<Exercise>> GetExercisesAsync(int id)
    {
      return await FindByCondition(x => x.UserId == id).ToListAsync();
    }

    public async Task<IEnumerable<Exercise>> GetExercisesByMuscleAsync(int id, string muscle)
    {
      return await FindByCondition(x => x.UserId == id && x.MuscleGroup == muscle).ToListAsync();
    }
    public void CreateExercise(Exercise model)
    {
      Create(model);
    }

    public void UpdateExercise(int id, Exercise update)
    {
      var model = GetExerciseAsync(id);
      if (model == null)
        throw new System.Exception($"No Exercise");
      Update(update);
    }

    public async void DeleteExercise(int id)
    {
      Exercise model = await GetExerciseAsync(id);
      if (model != null)
        Delete(model);
    }
  }
}