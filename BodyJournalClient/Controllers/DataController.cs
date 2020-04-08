using Microsoft.AspNetCore.Mvc;
using BodyJournalClient.Models;

namespace BodyJournalClient.Controllers
{
  public class DataController : Controller
  {
    [Route("data")]
    public IActionResult Index()
    {
      // var allData = Data.GetAllData();
      return View();
    }

    [Route("data/{id}")]
    public IActionResult Details(int id)
    {
      // var thisData = Data.GetData(id);
      // thisData
      return View();
    }
    [Route("data/{id}/edit")]
    public IActionResult Edit(int id)
    {
      var editExercise = Exercise.GetExercise(id);
      return View(editExercise);
    }
  }
}
