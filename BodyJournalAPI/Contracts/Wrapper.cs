namespace BodyJournalAPI.Contracts
{
  public interface IRepositoryWrapper
  {
    IExerciseRepository Exercise { get; }
    IWorkoutRepository Workout { get; }
    IBiometricRepository Biometric { get; }
    IMuscleGroupFatigueRepository MuscleGroupFatigue { get; }
    IExerciseWorkoutRepository ExerciseWorkout { get; }
    void Save();
  }
}