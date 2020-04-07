namespace BodyJournalAPI.Contracts
{
  public interface IRepositoryWrapper
  {
    IExerciseRepository Exercise { get; }
    IWorkoutRepository Workout { get; }
    ISessionRepository Session { get; }
    IBiometricRepository Biometric { get; }
    IMuscleGroupFatigueRepository MuscleGroupFatigue { get; }
    void Save();
  }
}