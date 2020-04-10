using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BodyJournalClient.Models;

namespace BodyJournalClient.Controllers
{
  public class ExercisesController : Controller
  {
    [Route("exercises")]
    public IActionResult Index()
    {
      var allExercises = Exercise.GetAllExercises();
      return View(allExercises);
    }

    // [HttpPost]
    // public IActionResult Index(Exercise exercise)
    // {
    //   Exercise.CreateExercise(exercise);
    //   return RedirectToAction("Index");
    // }
    [Route("exercises/{id}")]
    public IActionResult Details(int id)
    {
      var thisExercise = Exercise.GetExercise(id);
      return View(thisExercise);
    }
    [Route("exercises/{id}/edit")]
    public IActionResult Edit(int id)
    {
      var editExercise = Exercise.GetExercise(id);
      return View(editExercise);
    }
    [Route("exercises/create")]
    public ActionResult Create()
    {
      // ViewBag.WorkoutId = new SelectList(Exercise., "TreatId", "Description");
      return View();
    }
    [HttpPost]
    public IActionResult Create(Exercise exercise)
    {
      Exercise.CreateExercise(exercise);
      return RedirectToAction("Index");
    }

    [HttpPost, Route("exercises/{id}")]
    public IActionResult Details(int id, Exercise exercise)
    {
      exercise.Id = id;
      Exercise.PutExercise(exercise);
      Console.WriteLine("Put Working");
      return RedirectToAction("Details", id);
    }
  }

}