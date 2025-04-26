using App.Infrastructure;
using App.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using App.Application.DTO;
using App.Application.Service;
using App.Application.Interfaces;
using App.Application.Validators;
using FluentValidation;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : Controller
    {
        private readonly ISignUpService _SignUpService;
        private readonly IValidator<SignUpDTO> _SignUpValidator;
        public SignUpController(ISignUpService signUpService , IValidator<SignUpDTO> SignUpValidator)
        {
            _SignUpService = signUpService;
            _SignUpValidator = SignUpValidator;
        }
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDTO request)
        {
            var validationResult = await _SignUpValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(new { message = validationResult.Errors.FirstOrDefault()?.ErrorMessage });
            }
            if (await _SignUpService.AsyncCheckSignUp(request))
            {
                return Ok(new { message = "Sign up successful" });
            }
            else
            {
                return BadRequest(new { message = "Username already exists" });
            }
        }
    }
}
