using App.Application.DTO;
using App.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace App.Infrastructure.Repository
{
    public class LoginRepository : ILoginRepository 
    {
        //private readonly AppDbContext _context;
        private readonly MongoDbContext _context;
        public LoginRepository(MongoDbContext context)
        {
            _context = context ;
        }
        public async Task<bool> AsyncCheckLogin(LoginDTO user)
        {
            var User = await  _context.Users.Where(u => 
                                    u.UserName == user.UserName &&
                                    u.Password == user.Password).FirstOrDefaultAsync(); // Lesa MongoDB
            return User != null;
        }
    }
}
