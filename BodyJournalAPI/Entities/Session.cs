using System;
using System.Collections.Generic;

namespace BodyJournalAPI.Entities
{
  public class Session
  {
    public int Id { get; set; }

    public DateTime TimeOfWorkout { get; set; }

    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }

    public virtual ICollection<Workout> Workouts { get; set; }
  }
}


