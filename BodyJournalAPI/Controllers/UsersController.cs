using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using BodyJournalAPI.Helpers;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using BodyJournalAPI.Services;
using BodyJournalAPI.Entities;
using BodyJournalAPI.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BodyJournalAPI.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;
    private IMapper _mapper;
    private readonly AppSettings _appSettings;

    public UsersController(
        IUserService userService,
        IMapper mapper,
        IOptions<AppSettings> appSettings)
    {
      _userService = userService;
      _mapper = mapper;
      _appSettings = appSettings.Value;
    }

    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]AuthenticateUser model)
    {
      Console.WriteLine("In authenticate api call: " + model);
      var user = _userService.Authenticate(model.UserName, model.Password);
      Console.WriteLine("Model after userservice call: " + user);
      if (user == null)
      {
        Console.WriteLine("user is null");
        return null;
      }

      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes("YourKey-2374-OFFKDI940NG7:56753253-tyuw-5769-0921-kfirox29zoxv");
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
            new Claim("USERID", user.Id.ToString())
            // new Claim("FIRSTNAME", user.FirstName),
            // new Claim("LASTNAME", user.LastName),
            // new Claim("USERNAME", user.UserName)
    }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      var JWToken = tokenHandler.WriteToken(token);
      Console.WriteLine("Tokenstring: " + JWToken);
      // return Ok(new { JWToken });
      // return basic user info and authentication token
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
      Console.WriteLine("In api register before trying to create: " + user);
      try
      {
        _userService.CreateUser(user, model.Password);
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
      var users = _userService.GetAllUsers();
      // var model = _mapper.Map<IList<ViewUser>>(users);
      return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
      var user = _userService.GetUserById(id);
      // var model = _mapper.Map<ViewUser>(user);
      return Ok(user);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody]UpdateUser model)
    {
      var user = _mapper.Map<User>(model);
      user.Id = id;

      try
      {
        _userService.UpdateUser(user, model.Password);
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
      _userService.DeleteUser(id);
      return Ok();
    }
  }
}