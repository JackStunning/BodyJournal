using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BodyJournalClient.ViewModels
{
  public class CreateWorkout
  {
    public string Name { get; set; }
    public int Satisfaction { get; set; }

    [Required]
    public IEnumerable<ViewExercise> Exercises { get; set; }
  }
}