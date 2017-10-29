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
        static List<Search> mystrings = new List<Search>()
        {
          new Search
          {
            query = "JabberJaw: Hi I'm JabberJaw"
          }
        };

        SearchDetails details = new SearchDetails() {AllText =  mystrings };
        [HttpGet]
        public ActionResult Index()
        {
            var model = details;
            Console.WriteLine(mystrings);
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(SearchDetails search)
        {
            if (ModelState.IsValid)
            {
                Search text = new Search();
                text.query = "User: "+search.newText;
                mystrings.Add(text);
                var model = details;
                return View(model);
            }
            else
            {
                return View(details);
            }
          
            //return RedirectToRoute("Home", "Index");
            // return View();
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