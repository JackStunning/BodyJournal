using System;

namespace BodyJournalAPI.Entities
{
  public class MuscleGroupFatigue // Biometrics
  {
    public int Id { get; set; }
    public int UpperBodyFatigue { get; set; }
    public int LowerBodyFatigue { get; set; }
    public DateTime CurrentTime { get; set; }

  }
}

//biometric