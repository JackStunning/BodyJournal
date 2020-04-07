using System.Threading.Tasks;
using RestSharp;

namespace BodyJournalClient.Helpers
{
  class ApiHelper
  {
    #region Exercise
    public static async Task<string> GetAllExercises()
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/exercises", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task<string> GetExercise(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/exercises/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task CreateExercise(string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/exercises", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task PutExercise(int id, string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/exercises/{id}", Method.PUT);

      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task DeleteExercise(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/exercises/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
    #endregion

    #region BioMetric
    public static async Task<string> GetAllBiometrics()
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/biometrics", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task<string> GetBiometric(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/biometrics/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task CreateBiometric(string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/biometrics", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task PutBiometric(int id, string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/biometrics/{id}", Method.PUT);

      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task DeleteBiometric(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/biometrics/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
    #endregion

    #region Workout

    public static async Task<string> GetAllWorkouts()
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/workouts", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task<string> GetWorkout(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/workouts/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task CreateWorkout(string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/workouts", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task PutWorkout(int id, string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/workouts/{id}", Method.PUT);

      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task DeleteWorkout(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/workouts/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
    #endregion

    #region Session

    public static async Task<string> GetAllSessions()
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/sessions", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task<string> GetSession(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/sessions/{id}", Method.GET);
      var response = await client.ExecuteAsync(request);
      return response.Content;
    }
    public static async Task CreateSession(string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/sessions", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task PutSession(int id, string model)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/sessions/{id}", Method.PUT);

      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(model);
      var response = await client.ExecuteAsync(request);
    }
    public static async Task DeleteSession(int id)
    {
      RestClient client = new RestClient("http://localhost:4000/api");
      RestRequest request = new RestRequest($"bodyjournal/sessions/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteAsync(request);
    }
    #endregion
  }
}







