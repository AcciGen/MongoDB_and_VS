using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMongoDB.Data
{
    public class DbContext
    {
        private readonly MongoClient mongoClient;
        public DbContext()
        {
            this.mongoClient = new MongoClient("mongodb://localhost:27017");

            var gdb = mongoClient.GetDatabase("Lesson");
        }

        public List<BsonDocument> GetDatabasesAsList()
        {
            return mongoClient.ListDatabases().ToList();
        }

        public IMongoDatabase GetDatabaseByName(string dbName)
        {
            return mongoClient.GetDatabase(dbName);
        }

        public async Task CreateNewCollectionAsync(IMongoDatabase database, string collectionName)
        {
            await database.CreateCollectionAsync(collectionName);
        }

        public async Task CreateNewCollectionAsync(string databaseName, string collectionName)
        {
            IMongoDatabase database = this.GetDatabaseByName(databaseName);
            await database.CreateCollectionAsync(collectionName);
        }

        public IMongoCollection<BsonDocument> GetMongoCollection(IMongoDatabase database, string collectionName)
        {
            return database.GetCollection<BsonDocument>(name: collectionName);
        }
    }
}
