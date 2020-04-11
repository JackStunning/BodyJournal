using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using BodyJournalClient.Models;
using BodyJournalClient.ViewModels.User;
using BodyJournalClient.Helpers;
using System;

namespace BodyJournalClient.Controllers
{
  public class AccountController : Controller
  {
    public AccountController()
    {
    }
    public ActionResult Index()
    {
      Console.WriteLine(HttpContext.User.Identity.IsAuthenticated);
      ApplicationUser objLoggedInUser = new ApplicationUser();
      if (User.Identity.IsAuthenticated)
      {
        Console.WriteLine(User);
        var claimsIndentity = HttpContext.User.Identity as ClaimsIdentity;
        var userClaims = claimsIndentity.Claims;

        if (HttpContext.User.Identity.IsAuthenticated)
        {
          foreach (var claim in userClaims)
          {
            var cType = claim.Type;
            var cValue = claim.Value;
            switch (cType)
            {
              case "USERID":
                objLoggedInUser.Id = cValue;
                break;
              case "FIRSTNAME":
                objLoggedInUser.FirstName = cValue;
                break;
              case "LASTNAME":
                objLoggedInUser.LastName = cValue;
                break;
              case "USERNAME":
                objLoggedInUser.Username = cValue;
                break;
            }
          }
          // ViewBag.UserRole = GetRole();
        }
      }
      return View("Index", objLoggedInUser);
    }
    public IActionResult Register()
    {
      return View();
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Authenticate(LoginViewModel model)
    {
      var userToken = await ApplicationUser.Authenticate(model);
      if (userToken != null)
      {
        HttpContext.Session.SetString("JWTtoken", userToken);
      }
      return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
      var result = await ApplicationUser.Register(model);
      Console.WriteLine(result);
      if (result != null)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public IActionResult LogOff()
    {
      HttpContext.Session.Clear();
      return RedirectToAction("Index");
    }

    public JsonResult EndSession()
    {
      HttpContext.Session.Clear();
      return Json(new { result = "success" });
    }
  }
}