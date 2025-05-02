
using MongoDB.Driver;

namespace App.Application.Interfaces
{
    public interface IBaseRepository
    {
        public Task<T> AddAsync<T>(T entity);

        public Task<T> UpdateAsync<T>(T entity);

        public Task<T> RemoveAsync<T>(T entity);

        public Task<T> GetAsync<T>(object id);
        public Task<T> FindOneAsync<T>(FilterDefinition<T> filter);
    }
}
