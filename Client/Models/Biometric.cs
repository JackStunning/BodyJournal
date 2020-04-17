using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BodyJournalClient.Helpers;

namespace BodyJournalClient.Models
{
  public class Biometric
  {
    public int Id;
    public static List<Biometric> GetAllBiometrics()
    {
      var apiCallTask = ApiHelper.GetAllBiometrics();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Biometric> model = JsonConvert.DeserializeObject<List<Biometric>>(jsonResponse.ToString());

      return model;
    }

    public static Biometric GetBiometric(int id)
    {
      var apiCallTask = ApiHelper.GetBiometric(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var model = JsonConvert.DeserializeObject<Biometric>(jsonResponse.ToString());

      return model;
    }
    public static void CreateBiometric(Biometric model)
    {
      string jsonBiometric = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.CreateBiometric(jsonBiometric);
    }

    public static void PutBiometric(Biometric model)
    {
      string jsonBiometric = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.PutBiometric(model.Id, jsonBiometric);
    }
    public static void DeleteBiometric(int id)
    {
      var apiCallTask = ApiHelper.DeleteBiometric(id);
    }
  }
}