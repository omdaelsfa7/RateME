using App.Domain.DTOs;

namespace App.Application.Interfaces
{
    public interface ISignUpService
    {
        public Task<bool> AsyncCheckSignUp(SignUpDTO user);
    }
}
