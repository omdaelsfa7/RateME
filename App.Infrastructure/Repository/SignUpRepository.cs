using App.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using App.Domain;
using App.Application.DTO;
using MongoDB.Driver;

namespace App.Infrastructure.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        private readonly IMongo _mongo;
        public SignUpRepository(IMongo mongo)
        {
            _mongo = mongo;
        }
        public async Task<bool> AsyncCheckSignUp(SignUpDTO Signuser)
        {
            var filter = Builders<User>.Filter.Eq(u => u.UserName, Signuser.UserName) &
                         Builders<User>.Filter.Eq(u => u.Email, Signuser.Email);
            var user = await _mongo.FindOneAsync<User>(filter);
            return (user == null);
        }
        public async Task<bool> AsyncSignUser(User user)
        {
           
                await _mongo.AddAsync(user);
                return true;
        }
    }
}
