using JabberJaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JabberJaw.Controllers
{
    public class HomeController : Controller
    {
        LearningDb _db = new LearningDb();
        // SearchDetails details = new SearchDetails();
        static List<Search> details = new List<Search>
        {
            new Search
            {
                query = "Hello this is JabberJaw"
            }
        };
       [HttpGet]
        public ActionResult Index()
        {
            var model = new SearchDetails();
            model.AllText = details;
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(SearchDetails details)
        {
            //if(ModelState.IsValid)
            //{
            //    _db.
            //}
            //var model = new FeedbackDetails();
            // model.AllFeedback = _db.getAllData();
            // return View(model);
            var model = new SearchDetails();
            model.AllText = details.AllText;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult About()
        {
            //This is the first use of .Name i made it up but it doesn't really matter
            //you can put .anything and it creates the specific type of data your retrieving
            ViewBag.Name = "Brandon";
            //you can also use a model by making a new instance of one and thus asccessing its properties
            var model = new AboutModels();
            model.Age = 21;
            model.Height = 5.4;
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Just skeletons for now";

            return View();
        }
       
        
    }
}