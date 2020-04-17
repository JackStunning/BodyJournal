using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace BodyJournalClient.ViewModels
{
  public class CreateWorkout
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime TimeOfWorkout { get; set; }

    [Required]
    public int Satisfaction { get; set; }

    [Required]
    public int IntensityScore { get; set; }
  }
}