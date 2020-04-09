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
    [Route("workouts")]
    public IActionResult Index()
    {
      var allWorkouts = Workout.GetAllWorkouts();
      return View(allWorkouts);
    }

    [Route("workouts/create")]
    public ActionResult Create()
    {
      List<Exercise> exercises = Exercise.GetAllExercises();

      ViewBag.ExerciseOne = new SelectList(exercises, "Id", "Name");
      ViewBag.ExerciseTwo = new SelectList(exercises, "Id", "Name");
      ViewBag.ExerciseThree = new SelectList(exercises, "Id", "Name");
      ViewBag.ExerciseFour = new SelectList(exercises, "Id", "Name");
      ViewBag.Exercise = new SelectList(Exercise.GetAllExercises(), "TreatId", "Description");
      return View();
    }

    [HttpPost("workouts/create")]
    public IActionResult Create(Workout workout, List<Exercise> exercises)
    {
      Workout.CreateWorkout(workout);
      return RedirectToAction("Index");
    }

    [Route("workouts/{id}")]
    public IActionResult Details(int id)
    {
      var thisWorkout = Workout.GetWorkout(id);
      return View(thisWorkout);
    }
    [Route("workouts/{id}/edit")]
    public IActionResult Edit(int id)
    {
      var editWorkout = Workout.GetWorkout(id);
      return View(editWorkout);
    }

    [HttpPost, Route("workouts/{id}")]
    public IActionResult Details(int id, Workout workout)
    {
      workout.Id = id;
      Workout.PutWorkout(workout);
      Console.WriteLine("Put Working");
      return RedirectToAction("Details", id);
    }
  }

}