namespace BodyJournalAPI.Entities
{
  public class Exercise
  {
    public int Id { get; set; }
    public int? Weight { get; set; }
    // Weight used, should have option to be null or ommitted b/c bodyweight exerices
    public int Reps { get; set; }
    // Number of Reps of an exercise
    public int Sets { get; set; }
    //Number of Sets of an exercise

    public string Name { get; set; }
    // Name of Exercises
    public string MuscleGroup { get; set; }
    // MuscleGroup Colllection of Muscle Groups 
    public int Intensity { get; set; }
  }
}