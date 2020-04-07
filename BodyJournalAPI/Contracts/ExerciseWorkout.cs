using BodyJournalAPI.Entities;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalAPI.Contracts
{
  public interface IExerciseWorkoutRepository : IRepositoryBase<ExerciseWorkout>
  {
    // ExerciseWorkout GetExerciseWorkout(int id);
    IEnumerable<ExerciseWorkout> GetExerciseWorkouts(int id);
  }
}