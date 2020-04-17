using System.ComponentModel.DataAnnotations.Schema;

namespace BodyJournalAPI.Entities
{
  [Table("exercises")]
  public class Exercise
  {
    public int Id { get; set; }
    public int? Weight { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }
    public string Name { get; set; }
    public string MuscleGroup { get; set; }
    public int Intensity { get; set; }
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
  }
}