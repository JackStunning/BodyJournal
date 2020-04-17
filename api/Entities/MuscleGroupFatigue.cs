using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BodyJournalAPI.Entities
{
  [Table("musclegroupfatigue")]
  public class MuscleGroupFatigue
  {
    public int Id { get; set; }
    public string MuscleGroup { get; set; }
    public int Fatigue { get; set; }
    public DateTime CurrentTime { get; set; }

    [ForeignKey(nameof(Workout))]
    public int WorkoutId { get; set; }
  }
}