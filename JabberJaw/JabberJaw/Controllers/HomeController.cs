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
        string previousWords = "";
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
               // response = convertToMessageSimple(response);
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
            //this is where the magic happens c# reading python output, ill need to write another method that uses this data and can parse it.
            previousWords = words;
            ProcessStartInfo start = new ProcessStartInfo();
            string result = "";
            start.FileName = "C:\\dev\\Python\\python2\\python.exe";
            start.Arguments = string.Format("{0} {1}", "C:\\dev\\Capstone\\JabberJaw\\JabberJaw\\Python\\RawText.py", words);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
            }
            return result;
        }
        public string convertToMessageSimple(string data)
        {
            //emergency plan need to regroup. 
            string package = data;
            if(package.Contains("Hello"))
            {
                package = "Hi I'm jabberJaw";
            }else if(package.Contains("How"))
            {
                package = "Right now? Not Well at All, I have memory problems?";
            }
            else if(package.Contains("Who"))
            {
                package = "Brandon Gregory Coats --- Python Wizard";
            }
            else
            {
                package = "I don't understand that.";
            }

            return package;
        }
        public ActionResult About()
        {
            mystrings.Clear();
            mystrings.Add(new Search() { query = "Hi I'm JabberJaw" });
            //This is the first use of .Name i made it up but it doesn't really matter
            //you can put .anything and it creates the specific type of data your retrieving
            ViewBag.Name = "Brandon";
            //you can also use a model by making a new instance of one and thus asccessing its properties
            var model = new AboutModels();
            model.Age = 21;
            model.Height = 5.4;
            return View(model);
        }
        public ActionResult FeedBack()
        {
            string lastJabberLog = details.AllText.Last().query;
            details.previousText = lastJabberLog;
            Session["details"] = details;
            return RedirectToAction("Index", "FeedBack");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Just skeletons for now";

            return View();
        }
       
        
    }
}