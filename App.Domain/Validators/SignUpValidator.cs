using FluentValidation;
using App.Domain.DTOs;

namespace App.Application.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpDTO>
    {
        public SignUpValidator()
        {
            RuleFor(c => c.UserName)
                .NotEmpty()
                .WithMessage("UserName is required")
                .Length(3, 15)
                .WithMessage("UserName must be between 3 and 20 characters long");


            RuleFor(c => c.Password).NotEmpty()
                .WithMessage("Password is required")
                .Length(8, 20)
                .WithMessage("Password must be between 6 and 20 characters long")
                .Matches(@"[0-9]+")
                .WithMessage("Password must contain at least one number")
                .Matches(@"[A-Z]+")
                .WithMessage("Password must contain at least one uppercase letter");

            RuleFor(c => c.Email).NotEmpty()
                .WithMessage("Email is required")
                .EmailAddress()
                .WithMessage("Enter Valid Email");

            RuleFor(c => c.PhoneNumber).NotEmpty()
                .WithMessage("Phone Number is required")
                .Matches(@"^(010|011|012|015)\d{8}$")
                .WithMessage("Enter Valid Phone Number");
        }

    }
}
