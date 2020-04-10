using System;
using System.Collections.Generic;

namespace BodyJournalAPI.Entities
{
  public class Workout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime TimeOfWorkout { get; set; }
    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }
    public IEnumerable<Exercise> Exercises { get; set; }
  }
}

