using IdentityAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AuthenticateController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;

    public AuthenticateController(
        UserManager<IdentityUser> userManager, 
        RoleManager<IdentityRole> roleManager, 
        IConfiguration configuration)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }


    [HttpPost]
    [Route("login")]
    public void Login([FromBody] LoginModel model)
    {
        
    }

    [HttpPost]
    [Route("register")]
    public void Register([FromBody] RegisterModel model)
    {
        
    }
    
    [HttpPost]
    [Route("register-admin")]
    public void RegisterAdmin([FromBody] RegisterModel model)
    {
        
    }
}