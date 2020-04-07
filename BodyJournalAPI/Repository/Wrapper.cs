using BodyJournalAPI.Helpers;
using BodyJournalAPI.Contracts;

namespace BodyJournalAPI.Repository
{
  public class RepositoryWrapper : IRepositoryWrapper
  {
    private BodyJournalContext _bodyJournalContext;
    private IExerciseRepository _exercise;
    private IExerciseWorkoutRepository _exerciseWorkout;
    private IWorkoutRepository _workout;
    private IBiometricRepository _biometric;
    private IMuscleGroupFatigueRepository _muscleGroupFatigue;
    public RepositoryWrapper(BodyJournalContext bodyJournalContext)
    {
      _bodyJournalContext = bodyJournalContext;
    }

    public IExerciseRepository Exercise
    {
      get
      {
        if (_exercise == null)
        {
          _exercise = new ExerciseRepository(_bodyJournalContext);
        }

        return _exercise;
      }
    }

    public IWorkoutRepository Workout
    {
      get
      {
        if (_workout == null)
        {
          _workout = new WorkoutRepository(_bodyJournalContext);
        }

        return _workout;
      }
    }

    public IBiometricRepository Biometric
    {
      get
      {
        if (_biometric == null)
        {
          _biometric = new BiometricRepository(_bodyJournalContext);
        }
        return _biometric;
      }
    }

    public IMuscleGroupFatigueRepository MuscleGroupFatigue
    {
      get
      {
        if (_muscleGroupFatigue == null)
        {
          _muscleGroupFatigue = new MuscleGroupFatigueRepository(_bodyJournalContext);
        }
        return _muscleGroupFatigue;
      }
    }
    public IExerciseWorkoutRepository ExerciseWorkout
    {
      get
      {
        if (_exerciseWorkout == null)
        {
          _exerciseWorkout = new ExerciseWorkoutRepository(_bodyJournalContext);
        }

        return _exerciseWorkout;
      }
    }
    public void Save()
    {
      _bodyJournalContext.SaveChanges();
    }
  }
}