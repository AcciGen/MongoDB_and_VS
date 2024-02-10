using MongoDB.Bson;
using MongoDB.Driver;
using VSMongoDB.Data;

namespace VSMongoDB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new DbContext();

            IMongoCollection<BsonDocument>? collection = dbContext.GetMongoCollection("Lesson", "dotNet");

            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;
            BsonDocument bsonElements = new BsonDocument()
            {
                {"name", "Nuriddin" },
                {"location", new BsonDocument
                    {
                        {"lon",  123},
                        {"lat", -123}
                    }
                },
                {"gender", "real male" }
            };
            dbContext.InsertOneDocAsync()

        }
    }
}
