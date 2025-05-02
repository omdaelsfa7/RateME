using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace App.Application.Interfaces
{
    public interface IMongo
    {
        public Task<T> AddAsync<T>(T entity);

        public Task<T> UpdateAsync<T>(T entity);

        public Task<T> RemoveAsync<T>(T entity);

        public Task<T> GetAsync<T>(object id);
        public Task<T> FindOneAsync<T>(FilterDefinition<T> filter);
    }
}
