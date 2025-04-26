using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using App.Application.DTO;

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
