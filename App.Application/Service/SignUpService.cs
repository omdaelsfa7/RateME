using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Application.Interfaces;
using App.Application.DTO;
using App.Domain;

namespace App.Application.Service
{
    public class SignUpService : ISignUpService
    {
        private readonly ISignUpRepository _signUpRepo;             
        public SignUpService(ISignUpRepository signUpRepository)
        {
            _signUpRepo = signUpRepository;
        }

        public async Task<bool> AsyncCheckSignUp(SignUpDTO user)
        {
            bool canSignUp = await _signUpRepo.AsyncCheckSignUp(user);
            if (canSignUp)
            {

                await _signUpRepo.AsyncSignUser(new User
                {
                    UserName = user.UserName,
                    Password = user.Password,
                    Email = user.Email,                    // lw h add User 3ade yb2a DTO wla la 
                    PhoneNumber = user.PhoneNumber,
                    FullName = user.FullName
                }
                ) ;  
                return true;
            }
            return false;
        }

    }
}
