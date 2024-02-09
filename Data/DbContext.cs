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

            foreach (var db in mongoClient.ListDatabases().ToList())
            {
                Console.WriteLine(db);
            }
        }
    }
}
