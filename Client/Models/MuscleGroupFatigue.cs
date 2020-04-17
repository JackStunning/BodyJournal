using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BodyJournalClient.Helpers;
using System;

namespace BodyJournalClient.Models
{
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
    public int WorkoutId { get; set; }
    public static List<MuscleGroupFatigue> GetAllMuscleGroupFatigues()
    {
      var apiCallTask = ApiHelper.GetAllMuscleGroupFatigues();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<MuscleGroupFatigue> model = JsonConvert.DeserializeObject<List<MuscleGroupFatigue>>(jsonResponse.ToString());

      return model;
    }

    public static MuscleGroupFatigue GetMuscleGroupFatigue(int id)
    {
      var apiCallTask = ApiHelper.GetMuscleGroupFatigue(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var model = JsonConvert.DeserializeObject<MuscleGroupFatigue>(jsonResponse.ToString());

      return model;
    }
    public static void CreateMuscleGroupFatigue(MuscleGroupFatigue model)
    {
      string jsonMuscleGroupFatigue = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.CreateMuscleGroupFatigue(jsonMuscleGroupFatigue);
    }

    public static void PutMuscleGroupFatigue(MuscleGroupFatigue model)
    {
      string jsonMuscleGroupFatigue = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.PutMuscleGroupFatigue(model.Id, jsonMuscleGroupFatigue);
    }
    public static void DeleteMuscleGroupFatigue(int id)
    {
      var apiCallTask = ApiHelper.DeleteMuscleGroupFatigue(id);
    }
  }
}