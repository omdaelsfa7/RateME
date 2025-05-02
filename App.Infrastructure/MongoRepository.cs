using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Application.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace App.Infrastructure
{
    public class MongoRepository : IMongo
    {
        private readonly IMongoDatabase _database;
        public MongoRepository(IOptions<MongoSettings> mongoSettings)
        {
            var connectionString = mongoSettings.Value.MongoConnection;
            var databaseName = mongoSettings.Value.DataBaseName;

            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(databaseName))
            {
                throw new ArgumentNullException("MongoDB connection string or database name is missing.");
            }

            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public async Task<T> AddAsync<T>(T entity)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            await collection.InsertOneAsync(entity);
            return entity;
        }
        public async Task<T> UpdateAsync<T>(T entity)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            await collection.ReplaceOneAsync(Builders<T>
                            .Filter.Eq("_id", entity.GetType().GetProperty("_id")
                            .GetValue(entity)), entity);
            return entity;
        }
        public async Task<T> RemoveAsync<T>(T entity)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            await collection.DeleteOneAsync(Builders<T>
                            .Filter.Eq("_id", entity.GetType().GetProperty("_id")
                            .GetValue(entity)));
            return entity;
        }
        public async Task<T> GetAsync<T>(object id)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            return await collection.Find(Builders<T>
                            .Filter.Eq("_id", id)).FirstOrDefaultAsync();
        }
        public async Task<T> FindOneAsync<T>(FilterDefinition<T> filter)
        {
            var collection = _database.GetCollection<T>(typeof(T).Name);
            return await collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}
