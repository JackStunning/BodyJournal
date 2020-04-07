using System;
using Microsoft.AspNetCore.Mvc;
using BodyJournalClient.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalClient.Controllers
{
  public class WorkoutsController : Controller
  {
    public IActionResult Index()
    {
      var allWorkouts = Workout.GetAllWorkouts();
      return View(allWorkouts);
    }

    [HttpPost]
    public IActionResult Index(Workout workout)
    {

      Workout.CreateWorkout(workout);

      var exercises = Exercise.GetAllExercises();

      List<SelectListItem> exercisesSelectList = new List<SelectListItem>();

      exercisesSelectList.AddRange(exercises.Select(a =>
      new SelectListItem
      {
        Value = a.Id.ToString(),
        Text = a.Name + " " + a.MuscleGroup + " " + a.Intensity
      }
      ).OrderBy(n => n.Text));

      ViewBag.ExerciseId = exercisesSelectList;

      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var thisWorkout = Workout.GetWorkout(id);
      return View(thisWorkout);
    }

    public IActionResult Edit(int id)
    {
      var editWorkout = Workout.GetWorkout(id);
      return View(editWorkout);
    }


    [HttpPost]
    public IActionResult Details(int id, Workout workout)
    {
      workout.Id = id;
      Workout.PutWorkout(workout);
      Console.WriteLine("Put Working");
      return RedirectToAction("Details", id);
    }
  }

}