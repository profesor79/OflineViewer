using System.Linq;
using MongoDB.Driver;

namespace OflineViewer
{
    public class Converter
    {
        public void Convert()
        {
            var context = new glpEntities();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<PX_Ballot>("collectionNAme");

            var ballot = context.PX_Ballot.First();
            collection.InsertOne(ballot);
        }
    }
}