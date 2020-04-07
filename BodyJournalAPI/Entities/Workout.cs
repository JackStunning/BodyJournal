using System.Collections.Generic;
using System;

namespace BodyJournalAPI.Entities
{
  public enum ExerciseIntensity
  {
    Low,
    Medium,
    High
  }

  public class Workout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime TimeOfWorkout { get; set; }
    // Keeps Track of the Time of Workout
    public int Satisfaction { get; set; }
    // User inputed Satisfaction score out of 5
    public int IntensityScore { get; set; }
    // Adds Score from all Exercises in Workout and returns that score divided by number of exercises
    // public virtual ICollection<Exercise> Exercises { get; set; }
    // Collection of Exercises that comprises this Workout
  }
}

