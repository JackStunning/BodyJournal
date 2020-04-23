using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Models;
using Microsoft.Extensions.Logging;
using BodyJournalAPI.Contracts;
using BodyJournalAPI.Helpers;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BodyJournalAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private IRepositoryWrapper _db;
    private readonly ILogger<UsersController> _logger;
    private IMapper _mapper;
    private readonly AppSettings _appSettings;
    public UsersController(ILogger<UsersController> logger, IRepositoryWrapper db, IMapper mapper, IOptions<AppSettings> appSettings)
    {
      _mapper = mapper;
      _db = db;
      _logger = logger;
      _appSettings = appSettings.Value;
    }
    #region Users
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]AuthenticateUser model)
    {
      var user = _db.User.Authenticate(model.UserName, model.Password);
      if (user == null)
        return BadRequest(new { message = "Username or password is incorrect" });

      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.Name, user.Id.ToString())
        }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      var JWToken = tokenHandler.WriteToken(token);
      return Ok(new
      {
        Id = user.Id,
        Username = user.UserName,
        FirstName = user.FirstName,
        LastName = user.LastName,
        Token = JWToken
      });
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public IActionResult Register([FromBody]RegisterUser model)
    {
      var user = _mapper.Map<User>(model);
      try
      {
        _db.User.CreateUser(user, model.Password);
        _db.Save();
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _db.User.GetAllUsers();
      var model = _mapper.Map<IEnumerable<ViewUser>>(users);
      return Ok(model);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
      var user = _db.User.GetUserById(id);
      var model = _mapper.Map<ViewUser>(user);
      return Ok(model);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody]UpdateUser model)
    {
      var user = _mapper.Map<User>(model);
      user.Id = id;

      try
      {
        _db.User.UpdateUser(user, model.Password);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(new { message = ex.Message });
      }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      _db.User.DeleteUser(id);
      return Ok();
    }
    #endregion

    #region Exercises
    [HttpGet("exercises/{id}")]
    public async Task<IActionResult> GetExercise(int id)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      return Ok(await _db.Exercise.GetExerciseAsync(id));
    }
    [HttpGet("exercises")]
    public async Task<IActionResult> GetExercises()
    {
      var currentUserId = int.Parse(User.Identity.Name);
      var model = await _db.Exercise.GetExercisesAsync(currentUserId);
      return Ok(model);
    }
    [HttpGet("exercises/{muscle}")]
    public async Task<IActionResult> GetExercisesByMuscleGroup(string muscle)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      var model = await _db.Exercise.GetExercisesByMuscleAsync(currentUserId, muscle);
      return Ok(model);
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
    public async Task<IActionResult> GetWorkout(int id)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      Workout model = await _db.Workout.GetWorkoutAsync(id);
      ViewWorkout workout = _mapper.Map<ViewWorkout>(model);
      workout.Exercises = _mapper.Map<IEnumerable<ViewExercise>>(workout.Exercises);
      return Ok(workout);
    }

    [HttpGet("workouts")]
    public async Task<IActionResult> GetWorkouts()
    {
      var currentUserId = int.Parse(User.Identity.Name);
      var model = await _db.Workout.GetWorkoutsAsync(currentUserId);
      return Ok(model);
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
    public async Task<IActionResult> GetBiometric(int id)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      return Ok(await _db.Biometric.GetBiometricAsync(id));
    }
    [HttpGet("biometrics")]
    public async Task<IActionResult> GetBiometrics()
    {
      var currentUserId = int.Parse(User.Identity.Name);
      return Ok(await _db.Biometric.GetBiometricsAsync(currentUserId));
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
    [HttpGet("musclefatigue/{id}")]
    public async Task<IActionResult> GetMuscleGroupFatigue(int Id)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      return Ok(await _db.MuscleGroupFatigue.GetMuscleGroupFatigueAsync(Id));
    }
    [HttpGet("musclefatigue")]
    public async Task<IActionResult> GetMuscleGroupFatigues()
    {
      var currentUserId = int.Parse(User.Identity.Name);
      return Ok(await _db.MuscleGroupFatigue.GetMuscleGroupFatiguesAsync());
    }
    [HttpPost("musclefatigue")]
    public void CreateMuscleGroupFatigue([FromForm] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.CreateMuscleGroupFatigue(model);
      _db.Save();
    }
    [HttpPut("musclefatigue/{id}")]
    public IActionResult UpdateMuscleGroupFatigue(int id, [FromBody] MuscleGroupFatigue model)
    {
      _db.MuscleGroupFatigue.UpdateMuscleGroupFatigue(id, model);
      _db.Save();
      return Ok();
    }

    [HttpDelete("musclefatigue/{id}")]
    public IActionResult DeleteMuscleGroupFatigue(int id)
    {
      _db.MuscleGroupFatigue.DeleteMuscleGroupFatigue(id);
      _db.Save();
      return Ok();
    }
    #endregion
  }
}
