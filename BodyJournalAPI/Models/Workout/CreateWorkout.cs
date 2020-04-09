using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace BodyJournalAPI.Models
{
  public class CreateWorkout
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime TimeOfWorkout { get; set; }
    // Keeps Track of the Time of Workout
    [Required]
    public int Satisfaction { get; set; }
    // User inputed Satisfaction score out of 5
    [Required]
    public int IntensityScore { get; set; }
  }
}