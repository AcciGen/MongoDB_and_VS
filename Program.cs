using MongoDB.Bson;
using MongoDB.Driver;
using VSMongoDB.Data;

namespace VSMongoDB
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var dbContext = new DbContext();

            IMongoCollection<BsonDocument>? collection = dbContext.GetMongoCollection("Lesson", "dotNet");

            collection.InsertManyAsync()
        }
    }
}
