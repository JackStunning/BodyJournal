using System.Collections.Generic;
using System;

namespace BodyJournalAPI.Models
{
  public class ViewWorkout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime TimeOfWorkout { get; set; }
    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }
    public IEnumerable<ViewExercise> Exercises { get; set; }
  }
}