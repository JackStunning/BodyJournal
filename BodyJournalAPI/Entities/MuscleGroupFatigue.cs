using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace BodyJournalAPI.Entities
{
  public class MuscleGroupFatigue // Biometrics
  {
    public int Id { get; set; }


    public int BackFatigue { get; set; }
    public int ChestFatigue { get; set; }
    public int ArmsFatigue { get; set; }

    public int AbsFatigue { get; set; }
    public int LegsFatigue { get; set; }
    public int ShouldersFatigue { get; set; }

    // User inputs Fatigue Level 1-5
    public DateTime CurrentTime { get; set; }

    [ForeignKey(nameof(Workout))]
    public int WorkoutId { get; set; }
  }
}

//For each exercise in workout get the muscle group

//biometric

// MuscleGroup - Back, Chest, Arms, Abs, Legs
// Creates New - Table with these elements
// Tracks Fatigue level within each collum of Back, Chest, etc
// When the fatigue level was inputted?
// Number of Days From Working out y Muscle group to Reach x Fatigue level in y Muscle group
//Fatigue level is going to be determined from using the fatigue amount generated from the level of intensity for a muscle group for a workout minus the initial # of days needed
//to reach zero 