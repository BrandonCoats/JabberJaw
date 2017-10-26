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
        static List<Search> detail = new List<Search>
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
            model.AllText = detail;
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(Search details)
        {
            if (ModelState.IsValid)
            {
                Search newSearch = details;
                detail.Add(newSearch);
            }
            return View("Index", details);
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