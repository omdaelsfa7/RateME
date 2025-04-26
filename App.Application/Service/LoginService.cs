using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Application.DTO;
using App.Application.Interfaces;

namespace App.Application.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepo;
        public LoginService(ILoginRepository loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public async Task<bool> AsyncCheckLogin(LoginDTO user )
        {
            
            return await _loginRepo.AsyncCheckLogin(user);
        }
    }
}
