using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    
    public UserController()
    {
        
    }

    [HttpPost]
    public IActionResult Post(User user)
    {
        if (ModelState.IsValid == false)
        {
            return UnprocessableEntity("please fill all data!");
        }

        if (user.Password != user.ConfirmPassword)
        {
            return BadRequest("password and confirm does not match!");
        }
        
        //UserRepository.Create(user);
        return Ok("Hurray! User Created Successfully!");

    }


}