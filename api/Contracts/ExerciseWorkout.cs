using BodyJournalAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BodyJournalAPI.Contracts
{
  public interface IExerciseWorkoutRepository : IRepositoryBase<ExerciseWorkout>
  {
    Task<IEnumerable<ExerciseWorkout>> GetExerciseWorkoutsAsync(int id);
  }
}