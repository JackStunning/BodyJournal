using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BodyJournalClient.Helpers;

namespace BodyJournalClient.Models
{
  public class Workout
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Satisfaction { get; set; }
    public int IntensityScore { get; set; }
    public IEnumerable<Exercise> Exercises { get; set; }
    public static List<Workout> GetAllWorkouts()
    {
      var apiCallTask = ApiHelper.GetAllWorkouts();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Workout> model = JsonConvert.DeserializeObject<List<Workout>>(jsonResponse.ToString());

      return model;
    }

    public static Workout GetWorkout(int id)
    {
      var apiCallTask = ApiHelper.GetWorkout(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var model = JsonConvert.DeserializeObject<Workout>(jsonResponse.ToString());

      return model;
    }
    public static void CreateWorkout(Workout model)
    {
      string jsonWorkout = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.CreateWorkout(jsonWorkout);
    }

    public static void PutWorkout(Workout model)
    {
      string jsonWorkout = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.PutWorkout(model.Id, jsonWorkout);
    }
    public static void DeleteWorkout(int id)
    {
      var apiCallTask = ApiHelper.DeleteWorkout(id);
    }
  }
}