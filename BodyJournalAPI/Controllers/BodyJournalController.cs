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

    #region Exercises
    [HttpGet("exercises/{id}")]
    public IActionResult GetExercise(int Id)
    {
      return Ok(_db.Exercise.GetExercise(Id));
    }
    [HttpGet("exercises")]
    public IActionResult GetExercises()
    {
      return Ok(_db.Exercise.GetExercises());
    }
    [HttpPost("exercises")]
    public void CreateExercise([FromForm] Exercise model)
    {
      _db.Exercise.CreateExercise(model);
      _db.Save();
    }
    [HttpPut("exercises/{id}")]
    public IActionResult UpdateExercise(int id, [FromBody] Exercise model)
    {
      _db.Exercise.UpdateExercise(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("exercises/{id}")]
    public IActionResult DeleteExercise(int id)
    {
      _db.Exercise.DeleteExercise(id);
      _db.Save();
      return Ok();
    }
    #endregion

    #region Workouts
    [HttpGet("workouts/{id}")]
    public IActionResult GetWorkout(int Id)
    {
      return Ok(_db.Workout.GetWorkout(Id));
    }
    [HttpGet("workouts")]
    public IActionResult GetWorkouts()
    {
      return Ok(_db.Workout.GetWorkouts());
    }
    [HttpPost("workouts")]
    public void CreateWorkout([FromForm] Workout model)
    {
      _db.Workout.CreateWorkout(model);
      _db.Save();
    }
    [HttpPut("workouts/{id}")]
    public IActionResult UpdateWorkout(int id, [FromBody] Workout model)
    {
      _db.Workout.UpdateWorkout(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("workouts/{id}")]
    public IActionResult DeleteWorkout(int id)
    {
      _db.Workout.DeleteWorkout(id);
      _db.Save();
      return Ok();
    }
    #endregion

    #region Biometric

    [HttpGet("biometrics/{id}")]
    public IActionResult GetBiometric(int Id)
    {
      return Ok(_db.Biometric.GetBiometric(Id));
    }
    [HttpGet("biometrics/{id}")]
    public IActionResult GetBiometrics()
    {
      return Ok(_db.Biometric.GetBiometrics());
    }
    [HttpPost("biometrics/{id}")]
    public void CreateBiometric([FromForm] Biometric model)
    {
      _db.Biometric.CreateBiometric(model);
      _db.Save();
    }
    [HttpPut("biometrics/{id}")]
    public IActionResult UpdateBiometric(int id, [FromBody] Biometric model)
    {
      _db.Biometric.UpdateBiometric(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("biometrics/{id}")]
    public IActionResult DeleteBiometric(int id)
    {
      _db.Biometric.DeleteBiometric(id);
      _db.Save();
      return Ok();
    }
    #endregion

    #region MuscleGroupFatigue
    [HttpGet("muscle/status/{id}")]
    public IActionResult GetMuscleGroupFatigue(int Id)
    {
      return Ok(_db.MuscleGroupFatigue.GetMuscleGroupFatigue(Id));
    }
    [HttpGet("muscle/status")]
    public IActionResult GetMuscleGroupFatigues()
    {
      return Ok(_db.MuscleGroupFatigue.GetMuscleGroupFatigues());
    }
    [HttpPost("muscle/status")]
    public void CreateMuscleGroupFatigue([FromForm] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.CreateMuscleGroupFatigue(model);
      _db.Save();
    }
    [HttpPut("muscle/status/{id}")]
    public IActionResult UpdateMuscleGroupFatigue(int id, [FromBody] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.UpdateMuscleGroupFatigue(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("muscle/status/{id}")]
    public IActionResult DeleteMuscleGroupFatigue(int id)
    {
      _db.MuscleGroupFatigue.DeleteMuscleGroupFatigue(id);
      _db.Save();
      return Ok();
    }
    #endregion
  }
}
