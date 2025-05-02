using App.Application.DTO;
using App.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using App.Domain;
namespace App.Infrastructure.Repository
{
    public class LoginRepository : ILoginRepository 
    {

        private readonly IMongo _mongo;
        public LoginRepository(IMongo mongo)
        {
            _mongo = mongo ;
        }
        public async Task<bool> AsyncCheckLogin(LoginDTO user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.UserName, user.UserName) &
                         Builders<User>.Filter.Eq(u => u.Password, user.Password);
            var User = await  _mongo.FindOneAsync<User>(filter);
            return User != null;
        }
    }
}
