using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BodyJournalAPI.Repository
{
  public class ExerciseWorkoutRepository : RepositoryBase<ExerciseWorkout>,
  IExerciseWorkoutRepository
  {
    public ExerciseWorkoutRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }
    public async Task<IEnumerable<ExerciseWorkout>> GetExerciseWorkoutsAsync(int id)
    {
      return await FindByCondition(entry => entry.WorkoutId == id).ToListAsync();
    }
    public async Task<IEnumerable<ExerciseWorkout>> GetExerciseWorkoutAsync(int id)
    {
      return await FindByCondition(entry => entry.WorkoutId == id).ToListAsync();
    }
  }
}