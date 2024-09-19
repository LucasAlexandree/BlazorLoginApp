using BlazorLoginApp.Server.Services;
using Microsoft.AspNetCore.Mvc;
using LoginModel = BlazorLoginApp.Client.Pages.Login.LoginModel;

namespace BlazorLoginApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var success = await _authService.LoginAsync(model.Email, model.Password);
            if (success)
                return Ok();

            return Unauthorized();
        }
    }
}
