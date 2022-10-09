using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger _logger;
    
    public UserController(ILogger logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Post(User user)
    {
        if (ModelState.IsValid == false)
        {
            _logger.LogError("model is not valid!");
            return UnprocessableEntity("please fill all data!");
        }

        if (user.Password != user.ConfirmPassword)
        {
            _logger.LogTrace("password and confirm password does not match");
            return BadRequest("password and confirm does not match!");
        }
        
        //UserRepository.Create(user);
        _logger.LogInformation("that's it!");
        return Ok("Hurray! User Created Successfully!");

    }


}