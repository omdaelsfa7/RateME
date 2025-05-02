using App.Domain.DTOs;

namespace App.Application.Interfaces
{
    public interface ILoginRepository
    {
        public Task<bool> AsyncCheckLogin(LoginDTO user);
    }
}
