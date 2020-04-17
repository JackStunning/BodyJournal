using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BodyJournalAPI.Models
{
  public class UpdateWorkout
  {
    [Required]
    public string Name { get; set; }
    public int Satisfaction { get; set; }
    [Required]
    public IEnumerable<ViewExercise> Exercises { get; set; }
  }
}