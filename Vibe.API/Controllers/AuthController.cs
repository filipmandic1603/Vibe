using Microsoft.AspNetCore.Mvc;
using Vibe.Core.DTO;
using Vibe.Core.ServiceContract;

namespace Vibe.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{

    private readonly IUsersService _usersService;

    public AuthController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest loginRequest)
    {
        if(loginRequest == null)
        {
             return BadRequest("Invalid login");
        }

        AutheticationResponse? autheticationResponse = await _usersService.Login(loginRequest);


        if(autheticationResponse == null || autheticationResponse.Success==false)
        {
            return BadRequest(autheticationResponse);
        }

        return Ok(autheticationResponse);
    }

    [HttpPost("registration")]
    public async Task<IActionResult> Registration(RegisterRequest registerRequest)
    {
        if(registerRequest == null)
        {
            return BadRequest("Invalid registration");
        }

        AutheticationResponse? autheticationResponse = await _usersService.Register(registerRequest);

        if(autheticationResponse == null || autheticationResponse.Success==false)
        { 
            return BadRequest(autheticationResponse);
        }

        return Ok(autheticationResponse);
    }
}
