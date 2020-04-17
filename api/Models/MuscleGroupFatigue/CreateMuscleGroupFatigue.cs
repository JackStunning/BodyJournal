using System.ComponentModel.DataAnnotations;
using System;

namespace BodyJournalAPI.Models
{
  public class CreateMuscleGroupFatigue
  {
    [Required]
    public string MuscleGroup { get; set; }

    [Required]
    public int Fatigue { get; set; }

    [Required]
    public DateTime CurrentTime { get; set; } = DateTime.Now;

    [Required]
    public int WorkoutId { get; set; }
  }
}