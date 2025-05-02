using App.Domain.DTOs;

namespace App.Application.Interfaces
{
    public interface ILoginService
    {
        public Task<bool> AsyncCheckLogin(LoginDTO user);
    }
}
