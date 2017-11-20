using JabberJaw.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

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

        SearchDetails details = new SearchDetails() { AllText = mystrings };
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
                // details.inputString = search.newText;
                text.query = "User:" + search.newText;
                mystrings.Add(text);
                //user speech added 
                Search text2 = new Search();
                string response = responseSortedByOccurence(search.newText);
                // response = convertToMessageSimple(response);
                text2.query = "JabberJaw:" + response;
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
      
        public string responseSortedByOccurence(string words)
        {
            List<UseWords> allWordswithContext = getWordsWithContext(words);
            List<SortedResults> allResponses = new List<SortedResults>();
            //i need to fill up the responses and get the counts
            for(int i = 0; i < allWordswithContext.Count; i++)
            {
                List<LearningData> results = _db.getByWord(allWordswithContext[i].word).ToList();
                foreach(LearningData data in results)
                {
                    SortedResults result = new SortedResults(data, 1);
                    if(allResponses.Contains(result))
                    {
                        allResponses.Remove(result);
                        result.count = result.count + 1;
                        allResponses.Add(result);
                    }
                    else
                    {
                        allResponses.Add(result);
                    }
                    
                }
            }
            //should now have a list of just the resulkts and there accurate counts

            //sorted results should now have all the responses and there values use these to sort 
            string response = "I don't understand that";
            List<SortedResults> sortedByMatch = MatchFirstFilter(allResponses);
            List<SortedResults> sortedByMatchandUser = UserFirstFilter(allResponses);
            //i now know the bottom should be the number one answer because both have been sorted
            response = sortedByMatchandUser[0].data.response;//gives the response back
            return response;
        }
        private List<SortedResults> MatchFirstFilter(List<SortedResults> responsesAndCounts)
        {
            SortedResults currentBestResult = null;
            List<SortedResults> sortedListbyMatch = new List<SortedResults>();
            if(responsesAndCounts.Count > 0)
            {
                currentBestResult = responsesAndCounts[0];
            }
            while(sortedListbyMatch.Count != responsesAndCounts.Count)
            {
                for (int i = 0; i < responsesAndCounts.Count; i++)
                {
                    if (currentBestResult == null || currentBestResult.count < responsesAndCounts[i].count)
                    {//change happens here for the user preference
                        currentBestResult = responsesAndCounts[i];
                    }
                }
                if(currentBestResult != null)
                {
                    sortedListbyMatch.Add(currentBestResult);
                    currentBestResult = null;
                }
            }
            return sortedListbyMatch;
        }
        private List<SortedResults> UserFirstFilter(List<SortedResults> responsesAndCounts)
        {
            SortedResults currentBestResult = null;
            List<SortedResults> sortedListbyMatch = new List<SortedResults>();
            if (responsesAndCounts.Count > 0)
            {
                currentBestResult = responsesAndCounts[0];
            }
            while (sortedListbyMatch.Count != responsesAndCounts.Count)
            {
                for (int i = 0; i < responsesAndCounts.Count; i++)
                {
                    if (currentBestResult == null || responsesAndCounts[i].data.value > currentBestResult.data.value)
                    {//change happens here for the user preference
                        currentBestResult = responsesAndCounts[i];
                    }
                }
                if (currentBestResult != null)
                {
                    sortedListbyMatch.Add(currentBestResult);
                    currentBestResult = null;
                }
            }
            return sortedListbyMatch;
        }
        private List<UseWords> getWordsWithContext(string userInput)
        {
            List<string> wordAndPots = new List<string>();
            string[] indvWords = userInput.Split(' ');
            //gives back words as individuals as determined by the space
            for (int i = 0; i < indvWords.Length; i++)
            {
                string word = getPythonTokenized(indvWords[i]);
                //Console.WriteLine(word);
                wordAndPots.Add(word);
            }
            List<UseWords> wordsAndSpeech = new List<UseWords>();

            for (int i = 0; i < wordAndPots.Count; i++)
            {
                string wordParts = wordAndPots[i];
                string[] parts = wordParts.Split('\'');
                //for (int k = 0; k < parts.Length; k++)
                //{
                //    Console.WriteLine("Part: " + parts[k]);
                //}
                //actually grabs the parts based on the words
                UseWords wordandPart = new UseWords(parts[1], parts[3]);
                wordsAndSpeech.Add(wordandPart);
            }

            return wordsAndSpeech;
        }
        public string getPythonTokenized(string words)
        {
            string previousWords = "";
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
            string lastInput = details.AllText[details.AllText.Count - 2].query;
            string[] parts = lastInput.Split(':');
            details.inputString = parts[1].ToLower();
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