using System.ComponentModel.DataAnnotations;

namespace BodyJournalClient.ViewModels
{
  public class UpdateExercise
  {
    public int Weight { get; set; }

    public int Reps { get; set; }

    public int Sets { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string MuscleGroup { get; set; }

    [Required]
    public int Intensity { get; set; }
  }
}