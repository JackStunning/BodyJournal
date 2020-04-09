using System.Collections.Generic;

namespace BodyJournalClient.ViewModels
{
  public class ViewWorkout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }
    public IEnumerable<ViewExercise> Exercises { get; set; }
  }
}