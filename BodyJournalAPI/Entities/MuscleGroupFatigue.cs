using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BodyJournalAPI.Entities
{
  [Table("musclegroupfatigue")]
  public class MuscleGroupFatigue
  {
    public int Id { get; set; }
    public int BackFatigue { get; set; }
    public int ChestFatigue { get; set; }
    public int ArmsFatigue { get; set; }
    public int AbsFatigue { get; set; }
    public int LegsFatigue { get; set; }
    public int ShouldersFatigue { get; set; }
    public DateTime CurrentTime { get; set; }

    [ForeignKey(nameof(Workout))]
    public int WorkoutId { get; set; }
  }
}