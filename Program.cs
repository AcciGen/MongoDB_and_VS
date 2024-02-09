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

            IMongoDatabase database = dbContext.GetDatabaseByName("Lesson");

            List<BsonDocument>? collections = database.ListCollections().ToList();
            Console.WriteLine(collections);
        }
    }
}
