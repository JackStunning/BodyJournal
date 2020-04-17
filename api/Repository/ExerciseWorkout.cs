using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Helpers;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalAPI.Repository
{
  public class ExerciseWorkoutRepository : RepositoryBase<ExerciseWorkout>,
  IExerciseWorkoutRepository
  {
    public ExerciseWorkoutRepository(BodyJournalContext bodyJournalContext) : base(bodyJournalContext)
    {
    }
    public IEnumerable<ExerciseWorkout> GetExerciseWorkouts(int id)
    {
      return FindByCondition(entry => entry.WorkoutId == id);
    }
    public IEnumerable<ExerciseWorkout> GetExerciseWorkout(int id)
    {
      return FindByCondition(entry => entry.WorkoutId == id);
    }
  }
}