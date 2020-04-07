using System;
using System.Collections.Generic;

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
    public int UpperIntensityScore { get; set; }
    public int LowerIntensityScore { get; set; }
    public virtual ICollection<Exercise> Exercises { get; set; }
  }
}

