using App.Domain.DTOs;
using App.Domain.Models;


namespace App.Application.Interfaces
{
    public interface ISignUpRepository
    {
        public Task<bool> AsyncCheckSignUp(SignUpDTO user);
        public Task<bool> AsyncSignUser(User user);
    }
}
