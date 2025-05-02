using Microsoft.AspNetCore.Mvc;
using App.Domain.DTOs;
using App.Application.Interfaces;
using FluentValidation;


namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly IValidator<LoginDTO> _Loginvalidator;
        public LoginController(ILoginService loginService, IValidator<LoginDTO> LoginValidator)
        {
            _loginService = loginService;
            _Loginvalidator = LoginValidator;
        }

        [HttpPost("Login")]

        public async Task<IActionResult> Login([FromBody] LoginDTO request)
        {
            var ValidationResult = await _Loginvalidator.ValidateAsync(request);
            if (!ValidationResult.IsValid)
            {
                return BadRequest(new { message = ValidationResult.Errors.FirstOrDefault()?.ErrorMessage });
            }
            if (await _loginService.AsyncCheckLogin(request))
            {
                return Ok(new { message = "Login successful" });
            }
            else
            {
                return BadRequest(new { message = "Invalid username or password" });
            }
        }
    }

}
