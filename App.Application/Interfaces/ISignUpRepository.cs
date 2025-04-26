using App.Application.DTO;
using App.Domain;

namespace App.Application.Interfaces
{
    public interface ISignUpRepository
    {
        public Task<bool> AsyncCheckSignUp(SignUpDTO user);
        public Task<bool> AsyncSignUser(User user);
    }
}
