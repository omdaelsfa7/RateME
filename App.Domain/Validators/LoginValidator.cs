using FluentValidation;
using App.Domain.DTOs;

namespace App.Application.Validators
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            RuleFor(c => c.Email).NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress();

            RuleFor(c => c.Password).NotEmpty()
                .WithMessage("Password is required")
                .Length(8, 20);
        }
    }
}
