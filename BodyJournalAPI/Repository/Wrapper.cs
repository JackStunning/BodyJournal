using BodyJournalAPI.Helpers;
using BodyJournalAPI.Contracts;
using BodyJournalAPI.Entities;


namespace BodyJournalAPI.Repository
{
  public class RepositoryWrapper : IRepositoryWrapper
  {
    private BodyJournalContext _bodyJournalContext;
    private IExerciseRepository _exercise;
    private IWorkoutRepository _workout;
    private ISessionRepository _session;
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

    public ISessionRepository Session
    {
      get
      {
        if (_session == null)
        {
          _session = new SessionRepository(_bodyJournalContext);
        }

        return _session;
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
    public void Save()
    {
      _bodyJournalContext.SaveChanges();
    }
  }
}