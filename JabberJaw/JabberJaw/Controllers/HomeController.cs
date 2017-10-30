using JabberJaw.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
                //user speech added 
                Search text2 = new Search();
                string response = talkBot(search.newText);
                text2.query = "JabberJaw: " + response;
                mystrings.Add(text2);
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
        public string talkBot(string words)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            string result = "";
            start.FileName = "C:\\dev\\Python\\python2\\python.exe";
            start.Arguments = string.Format("{0} {1}", "C:\\dev\\Capstone\\JabberJaw\\JabberJaw\\Python\\SortByPartOfSpeech.py", words);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    // this prints 11
                    //Console.Write(result);

                }
            }
           // Console.Read();
            return result;
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