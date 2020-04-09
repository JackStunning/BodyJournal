using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BodyJournalClient.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
<<<<<<< HEAD

    public IActionResult Privacy()
    {
        return View();
    }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //   return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
=======
>>>>>>> 7f674dbeacdba8ab637d97385f8ed116854197d2
  }
}
