using App.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using App.Domain;
using App.Application.DTO;

namespace App.Infrastructure.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        //private readonly AppDbContext _context;
        private readonly MongoDbContext _context;
        public SignUpRepository(MongoDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AsyncCheckSignUp(SignUpDTO Signuser)
        {
            var user = await _context.Users
                .Where(u => u.UserName == Signuser.UserName)
                .FirstOrDefaultAsync();
            return user != null;
        }
        public async Task<bool> AsyncSignUser(User user)
        {
           
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
        }
    }
}
