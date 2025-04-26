using App.Application.DTO;

namespace App.Application.Interfaces
{
    public interface ILoginRepository
    {
        public Task<bool> AsyncCheckLogin(LoginDTO user);
    }
}
