using Microsoft.EntityFrameworkCore;
using BodyJournalAPI.Entities;
using System;

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
    public DbSet<MuscleGroupFatigue> MuscleGroupFatigues { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      #region Exercise
      builder.Entity<Exercise>().HasData(
      #region Chest 1 through 4
          new Exercise { Id = 1, Name = "Wide Pushup", MuscleGroup = "Chest", Weight = null, Reps = 10, Sets = 3, Intensity = 3 },
               new Exercise { Id = 2, Name = "Narrow Pushup", MuscleGroup = "Chest", Weight = null, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 3, Name = "Bench Press", MuscleGroup = "Chest", Weight = 200, Reps = 5, Sets = 3, Intensity = 5 },
               new Exercise { Id = 4, Name = "Decline Bench Press", MuscleGroup = "Chest", Weight = 100, Reps = 10, Sets = 3, Intensity = 3 },
      #endregion

      #region Back 5 through 8
          new Exercise { Id = 5, Name = "Seated Row", MuscleGroup = "Back", Weight = 150, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 6, Name = "Back Extension", MuscleGroup = "Back", Weight = 90, Reps = 10, Sets = 3, Intensity = 2 },
               new Exercise { Id = 7, Name = "Deadlift", MuscleGroup = "Back", Weight = 300, Reps = 5, Sets = 3, Intensity = 5 },
               new Exercise { Id = 8, Name = "TBar row", MuscleGroup = "Back", Weight = 200, Reps = 8, Sets = 3, Intensity = 4 },
      #endregion

      #region Arms 9 through 12
          new Exercise { Id = 9, Name = "Hammer Curl", MuscleGroup = "Arms", Weight = 20, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 10, Name = "Rotating Curl", MuscleGroup = "Arms", Weight = 20, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 11, Name = "Tricep Extension", MuscleGroup = "Arms", Weight = 20, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 12, Name = "Upright Row", MuscleGroup = "Arms", Weight = 70, Reps = 10, Sets = 3, Intensity = 4 },
      #endregion

      #region Abs 13 through 16
          new Exercise { Id = 13, Name = "Sit Up", MuscleGroup = "Abs", Weight = null, Reps = 10, Sets = 3, Intensity = 2 },
               new Exercise { Id = 14, Name = "Plank", MuscleGroup = "Abs", Weight = null, Reps = 1, Sets = 3, Intensity = 2 },
               new Exercise { Id = 15, Name = "Bicycle", MuscleGroup = "Abs", Weight = null, Reps = 25, Sets = 3, Intensity = 3 },
               new Exercise { Id = 16, Name = "Leg Rasises", MuscleGroup = "Abs", Weight = null, Reps = 15, Sets = 3, Intensity = 2 },
      #endregion

      #region Legs 17 through 20
          new Exercise { Id = 17, Name = "Squat", MuscleGroup = "Legs", Weight = null, Reps = 10, Sets = 3, Intensity = 2 },
               new Exercise { Id = 18, Name = "Calf Raise", MuscleGroup = "Legs", Weight = 40, Reps = 10, Sets = 3, Intensity = 1 },
               new Exercise { Id = 19, Name = "Lunge", MuscleGroup = "Legs", Weight = 40, Reps = 10, Sets = 3, Intensity = 3 },
               new Exercise { Id = 20, Name = "DeadLift", MuscleGroup = "Legs", Weight = 160, Reps = 10, Sets = 3, Intensity = 4 },
      #endregion

      #region Shoulders 21 through 24
          new Exercise { Id = 21, Name = "Dumbell Shoulder Press", MuscleGroup = "Shoulders", Weight = 35, Reps = 10, Sets = 3, Intensity = 4 },
               new Exercise { Id = 22, Name = "Barbell Shoulder Press", MuscleGroup = "Shoulders", Weight = 70, Reps = 10, Sets = 3, Intensity = 3 },
               new Exercise { Id = 23, Name = "Military Press", MuscleGroup = "Shoulders", Weight = 70, Reps = 10, Sets = 3, Intensity = 3 },
               new Exercise { Id = 24, Name = "Side Lateral Raise", MuscleGroup = "Shoulders", Weight = 35, Reps = 10, Sets = 3, Intensity = 3 });
      #endregion
      #endregion

      #region Workout
      builder.Entity<Workout>().HasData(
      //uses c1, b5
      new Workout { Id = 1, Name = "Upper body day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 7 },
      //uses l 17 and 18
      new Workout
      {
        Id = 2,
        Name = "Lower body day",
        TimeOfWorkout = DateTime.
      Now,
        Satisfaction = 5,
        IntensityScore = 3
      },
      //21 and 22
      new Workout { Id = 3, Name = "Shoulder day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 7 },
      //b6 and b7
      new Workout { Id = 4, Name = "Back day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 6 },
      //abs 13 and 14
      new Workout { Id = 5, Name = "Abs day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 4 },
      //c1 and c3
      new Workout { Id = 6, Name = "Chest day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 8 },
      //9 and 12
      new Workout { Id = 7, Name = "Arms day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 8 },
      //legs 17,(2) and 20,(4)
      new Workout { Id = 8, Name = "Legs day", TimeOfWorkout = DateTime.Now, Satisfaction = 5, IntensityScore = 6 }
  );
      #endregion

      #region ExerciseWorkout
      builder.Entity<ExerciseWorkout>().HasData(
          //Upper body day
          new ExerciseWorkout { Id = 1, ExerciseId = 1, WorkoutId = 1 },
          new ExerciseWorkout { Id = 2, ExerciseId = 5, WorkoutId = 1 },

          // Lower body Day
          new ExerciseWorkout { Id = 3, ExerciseId = 17, WorkoutId = 2 },
          new ExerciseWorkout { Id = 4, ExerciseId = 18, WorkoutId = 2 },

          // Shoulder Day
          new ExerciseWorkout { Id = 5, ExerciseId = 21, WorkoutId = 3 },
          new ExerciseWorkout { Id = 6, ExerciseId = 22, WorkoutId = 3 },

          //Back Day
          new ExerciseWorkout { Id = 7, ExerciseId = 5, WorkoutId = 4 },
          new ExerciseWorkout { Id = 8, ExerciseId = 6, WorkoutId = 4 },

          // Abs Day
          new ExerciseWorkout { Id = 9, ExerciseId = 13, WorkoutId = 5 },
          new ExerciseWorkout { Id = 10, ExerciseId = 14, WorkoutId = 5 },

          // Chest Day
          new ExerciseWorkout { Id = 11, ExerciseId = 3, WorkoutId = 6 },
          new ExerciseWorkout { Id = 12, ExerciseId = 4, WorkoutId = 6 },

          // Arms Day
          new ExerciseWorkout { Id = 13, ExerciseId = 9, WorkoutId = 7 },
          new ExerciseWorkout { Id = 14, ExerciseId = 11, WorkoutId = 7 },

          // Legs Day
          new ExerciseWorkout { Id = 15, ExerciseId = 17, WorkoutId = 8 },
          new ExerciseWorkout { Id = 16, ExerciseId = 20, WorkoutId = 8 }
       );
      #endregion

      #region MuscleGroupFatigue
      builder.Entity<MuscleGroupFatigue>().HasData(
      new MuscleGroupFatigue { Id = 1, BackFatigue = 2, ChestFatigue = 4, LegsFatigue = 1, ArmsFatigue = 1, ShouldersFatigue = 1, CurrentTime = DateTime.Now, WorkoutId = 6 },
      new MuscleGroupFatigue { Id = 2, BackFatigue = 1, ChestFatigue = 1, LegsFatigue = 1, ArmsFatigue = 1, ShouldersFatigue = 4, CurrentTime = DateTime.Now, WorkoutId = 3 },
      new MuscleGroupFatigue { Id = 3, BackFatigue = 3, ChestFatigue = 4, LegsFatigue = 3, ArmsFatigue = 3, ShouldersFatigue = 3, CurrentTime = DateTime.Now, WorkoutId = 4 },
      new MuscleGroupFatigue { Id = 4, BackFatigue = 1, ChestFatigue = 1, LegsFatigue = 2, ArmsFatigue = 3, ShouldersFatigue = 3, CurrentTime = DateTime.Now, WorkoutId = 8 },
      new MuscleGroupFatigue { Id = 5, BackFatigue = 5, ChestFatigue = 3, LegsFatigue = 3, ArmsFatigue = 3, ShouldersFatigue = 5, CurrentTime = DateTime.Now, WorkoutId = 5 }
      // new MuscleGroupFatigue { Id = 6, MuscleGroup = "Chest", Fatigue = 1, CurrentTime = DateTime.Now, WorkoutId = 1 },
      // new MuscleGroupFatigue { Id = 5, MuscleGroup = "Abs", Fatigue = 1, CurrentTime = DateTime.Now, WorkoutId = 5 }
      // new MuscleGroupFatigue { Id = 6, MuscleGroup = "Chest", Fatigue = 1, CurrentTime = DateTime.Now, WorkoutId = 1 },
      );
      #endregion
    }
  }
}