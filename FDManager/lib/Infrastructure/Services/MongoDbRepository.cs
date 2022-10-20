using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Shared.Abstract;
using Shared.Interfaces;
using Shared.Options;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    internal sealed class MongoDbRepository<T> : IRepository<T> where T : DataModelBase<T>
    {
        MongoClient _client;
        IMongoDatabase _database;
        string _collectionName = string.Empty;

        public MongoDbRepository(IOptions<MongoDbOptions> opts)
        {
            if (opts == null)
                throw new ArgumentNullException(nameof(opts));

            var options = opts.Value;

            _client = new(connectionString: options.ConnectionString);

            _database = _client.GetDatabase(options.DatabaseName);

            _collectionName = $"{typeof(T).Name}s".ToLowerInvariant();
        }

        public bool IsConnected => _client is not null;

        public async IAsyncEnumerable<T> GetAsync(Expression<Func<bool, T>>? predicate)
        {
            var collection = _database.GetCollection<T>(_collectionName);

            var filter = new BsonDocument();

            var results = await collection.FindAsync(filter);

            foreach (var item in await results.ToListAsync())
                yield return item;

            if (predicate != null)
            {
                
            }
            else
            {
                
            }            
        }

        public async Task Save(T entity)
        {
            var collection = _database.GetCollection<T>(_collectionName);

            await collection.InsertOneAsync(entity);
        }

        public async Task<int> SaveMany(IEnumerable<T> entities)
        {
            var collection = _database.GetCollection<T>(_collectionName);

            await collection.InsertManyAsync(entities);

            return entities.Count();
        }
    }
}
