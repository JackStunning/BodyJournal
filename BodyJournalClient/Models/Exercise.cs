using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BodyJournalClient.Helpers;

namespace BodyJournalClient.Models
{
  public class Exercise
  {
    public int Id { get; set; }
    public int? Weight { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }
    public string Name { get; set; }
    public string MuscleGroup { get; set; }
    public int Intensity { get; set; }
    public static List<string> MuscleGroupList = new List<string> { "Arms", "Abs", "Chest", "Legs", "Shoulders", "Back" };
    public static List<Exercise> GetAllExercises()
    {
      var apiCallTask = ApiHelper.GetAllExercises();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Exercise> model = JsonConvert.DeserializeObject<List<Exercise>>(jsonResponse.ToString());

      return model;
    }

    public static Exercise GetExercise(int id)
    {
      var apiCallTask = ApiHelper.GetExercise(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var model = JsonConvert.DeserializeObject<Exercise>(jsonResponse.ToString());

      return model;
    }
    public static void CreateExercise(Exercise model)
    {
      string jsonExercise = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.CreateExercise(jsonExercise);
    }

    public static void PutExercise(Exercise model)
    {
      string jsonExercise = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.PutExercise(model.Id, jsonExercise);
    }
    public static void DeleteExercise(int id)
    {
      var apiCallTask = ApiHelper.DeleteExercise(id);
    }
  }
}