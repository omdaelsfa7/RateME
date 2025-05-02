
using App.Domain.DTOs;
using App.Application.Interfaces;

namespace App.Infrastructure.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepo;
        public LoginService(ILoginRepository loginRepo)
        {
            _loginRepo = loginRepo;
        }
        public async Task<bool> AsyncCheckLogin(LoginDTO user)
        {

            return await _loginRepo.AsyncCheckLogin(user);
        }
    }
}
