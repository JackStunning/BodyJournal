using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BodyJournalClient.Helpers;

namespace BodyJournalClient.Models
{
  public class Session
  {
    public int Id;
    public static List<Session> GetAllSessions()
    {
      var apiCallTask = ApiHelper.GetAllSessions();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Session> model = JsonConvert.DeserializeObject<List<Session>>(jsonResponse.ToString());

      return model;
    }

    public static Session GetSession(int id)
    {
      var apiCallTask = ApiHelper.GetSession(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      var model = JsonConvert.DeserializeObject<Session>(jsonResponse.ToString());

      return model;
    }
    public static void CreateSession(Session model)
    {
      string jsonSession = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.CreateSession(jsonSession);
    }

    public static void PutSession(Session model)
    {
      string jsonSession = JsonConvert.SerializeObject(model);
      var apiCallTask = ApiHelper.PutSession(model.Id, jsonSession);
    }
    public static void DeleteSession(int id)
    {
      var apiCallTask = ApiHelper.DeleteSession(id);
    }
  }
}