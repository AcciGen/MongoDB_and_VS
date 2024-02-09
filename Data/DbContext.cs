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

        public IMongoDatabase GetDatabaseByName(string dbName)
        {
            return mongoClient.GetDatabase(dbName);
        }
    }
}
