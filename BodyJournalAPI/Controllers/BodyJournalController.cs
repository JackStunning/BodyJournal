﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Contracts;

namespace BodyJournal.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BodyJournalController : ControllerBase
  {
    private IRepositoryWrapper _db;
    private readonly ILogger<BodyJournalController> _logger;

    public BodyJournalController(ILogger<BodyJournalController> logger, IRepositoryWrapper db)
    {
      _db = db;
      _logger = logger;
    }

    // Exercise Controller CRUD

    [HttpGet]
    public IActionResult GetExercise(int Id)
    {
      return Ok(_db.Exercise.GetExercise(Id));
    }
    [HttpGet]
    public IActionResult GetExercises()
    {
      return Ok(_db.Exercise.GetExercises());
    }
    [HttpPost]
    public void CreateExercise([FromForm] Exercise model)
    {
      _db.Exercise.CreateExercise(model);
      _db.Save();
    }
    [HttpPut]
    public IActionResult UpdateExercise(int id, [FromBody] Exercise model)
    {
      _db.Exercise.UpdateExercise(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteExercise(int id)
    {
      _db.Exercise.DeleteExercise(id);
      _db.Save();
      return Ok();
    }

    //ExerciseWorkout Controller



    //Workout Controller CRUD
    [HttpGet]
    public IActionResult GetWorkout(int Id)
    {
      return Ok(_db.Workout.GetWorkout(Id));
    }
    [HttpGet]
    public IActionResult GetWorkouts()
    {
      return Ok(_db.Workout.GetWorkouts());
    }
    [HttpPost]
    public void CreateWorkout([FromForm] Workout model)
    {
      _db.Workout.CreateWorkout(model);
      _db.Save();
    }
    [HttpPut]
    public IActionResult UpdateWorkout(int id, [FromBody] Workout model)
    {
      _db.Workout.UpdateWorkout(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteWorkout(int id)
    {
      _db.Workout.DeleteWorkout(id);
      _db.Save();
      return Ok();
    }
    //Session Controller CRUD

    [HttpGet]
    public IActionResult GetSession(int Id)
    {
      return Ok(_db.Session.GetSession(Id));
    }
    [HttpGet]
    public IActionResult GetSessions()
    {
      return Ok(_db.Session.GetSessions());
    }
    [HttpPost]
    public void CreateSession([FromForm] Session model)
    {
      _db.Session.CreateSession(model);
      _db.Save();
    }
    [HttpPut]
    public IActionResult UpdateSession(int id, [FromBody] Session model)
    {
      _db.Session.UpdateSession(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteSession(int id)
    {
      _db.Session.DeleteSession(id);
      _db.Save();
      return Ok();
    }

    //Biometric Controller CRUD

    [HttpGet]
    public IActionResult GetBiometric(int Id)
    {
      return Ok(_db.Biometric.GetBiometric(Id));
    }
    [HttpGet]
    public IActionResult GetBiometrics()
    {
      return Ok(_db.Biometric.GetBiometrics());
    }
    [HttpPost]
    public void CreateBiometric([FromForm] Biometric model)
    {
      _db.Biometric.CreateBiometric(model);
      _db.Save();
    }
    [HttpPut]
    public IActionResult UpdateBiometric(int id, [FromBody] Biometric model)
    {
      _db.Biometric.UpdateBiometric(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBiometric(int id)
    {
      _db.Biometric.DeleteBiometric(id);
      _db.Save();
      return Ok();
    }

    // MuscleGroupFatigue Controller CRUD

    [HttpGet]
    public IActionResult GetMuscleGroupFatigue(int Id)
    {
      return Ok(_db.MuscleGroupFatigue.GetMuscleGroupFatigue(Id));
    }
    [HttpGet]
    public IActionResult GetMuscleGroupFatigues()
    {
      return Ok(_db.MuscleGroupFatigue.GetMuscleGroupFatigues());
    }
    [HttpPost]
    public void CreateMuscleGroupFatigue([FromForm] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.CreateMuscleGroupFatigue(model);
      _db.Save();
    }
    [HttpPut]
    public IActionResult UpdateMuscleGroupFatigue(int id, [FromBody] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.UpdateMuscleGroupFatigue(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteMuscleGroupFatigue(int id)
    {
      _db.MuscleGroupFatigue.DeleteMuscleGroupFatigue(id);
      _db.Save();
      return Ok();
    }
  }
}
