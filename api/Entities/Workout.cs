using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace BodyJournalAPI.Entities
{
  [Table("workouts")]
  public class Workout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime TimeOfWorkout { get; set; }
    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
  }
}

