using Microsoft.EntityFrameworkCore;
using BodyJournalAPI.Entities;

namespace BodyJournalAPI.Helpers
{
  public class BodyJournalContext : DbContext
  {
    public BodyJournalContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Biometric> Biometrics { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Workout> Workouts { get; set; }
    public DbSet<ExerciseWorkout> ExerciseWorkouts { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<MuscleGroupFatigue> MuscleGroupFatigues { get; set; }
  }
}
