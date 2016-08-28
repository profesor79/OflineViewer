using System.Linq;
using System.Web.Mvc;
using BallotViewer.Web.Models;
using MongoDB.Driver;

namespace BallotViewer.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test2");
            var collection = database.GetCollection<BallotAggregated>("collectionB6");
            var ballots = collection.AsQueryable().Take(20).ToList();
            var model = new OfflineBallotViewModel(ballots);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}