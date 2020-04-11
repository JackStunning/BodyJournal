using Newtonsoft.Json;
using BodyJournalClient.Helpers;
using BodyJournalClient.ViewModels.User;
using System.Threading.Tasks;
using System;

namespace BodyJournalClient.Models
{
  public class ApplicationUser
  {
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public static async Task<string> Register(RegisterViewModel model)
    {
      Console.WriteLine("In register of application before jsonuser user: " + model.ToString());
      string jsonUser = JsonConvert.SerializeObject(model);
      Console.WriteLine("In register of application before apiCallTask json: " + jsonUser);
      var apiCallTask = await ApiHelper.RegisterUser(jsonUser);
      Console.WriteLine("In register of application after apiCallTask json: " + apiCallTask);
      return apiCallTask;
    }
    public static async Task<string> Authenticate(LoginViewModel model)
    {
      Console.WriteLine("In Authenticate of application before jsonuser user: " + model.ToString());
      string jsonUser = JsonConvert.SerializeObject(model);
      Console.WriteLine("In Authenticate of application before apiCallTask json: " + jsonUser);
      var apiCallTask = await ApiHelper.AuthenticateUser(jsonUser);
      Console.WriteLine("In Authenticate of application after apiCallTask json: " + apiCallTask);
      return apiCallTask;
    }
  }
}