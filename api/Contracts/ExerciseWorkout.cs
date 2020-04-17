using BodyJournalAPI.Entities;
using System.Collections.Generic;

namespace BodyJournalAPI.Contracts
{
  public interface IExerciseWorkoutRepository : IRepositoryBase<ExerciseWorkout>
  {
    IEnumerable<ExerciseWorkout> GetExerciseWorkouts(int id);
  }
}