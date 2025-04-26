using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Application.DTO;

namespace App.Application.Interfaces
{
    public interface ISignUpService
    {
        public Task<bool> AsyncCheckSignUp(SignUpDTO user); 
    }
}
