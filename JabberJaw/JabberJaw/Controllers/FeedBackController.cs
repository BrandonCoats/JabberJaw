using JabberJaw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JabberJaw.Controllers
{
    //[Authorize]
    public class FeedBackController : Controller
    {

    
        LearningDb _db = new LearningDb();
       static JabberJawData.LearningData dbData = new JabberJawData.LearningData();
        //need to remove to see the feedback page without signing in
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            //var model = new DatabaseRetrieval();
            //model.AllWithPartOfSpeech = _db.getAllbyPartOfSpeech("noun");
            if (Session["details"] != null)
            {
                //If so access it here
                SearchDetails dete = Session["details"] as SearchDetails;
                var model = dete;
                dbData.input = dete.inputString;
                Console.WriteLine(dete.inputString);
                return View(model);
            }
            else
            {
                return RedirectToRoute("Home", "Index");
            }
        }
        [HttpPost]
        public ActionResult Index(SearchDetails data)
        {
            //var model = new DatabaseRetrieval();
            //model.AllWithPartOfSpeech = _db.getAllbyPartOfSpeech("noun");
           
            var model = data;
            dbData.response = data.newText.ToLower();
            dbData.value = 50;
            _db.addRow(dbData);
            //i think this fixed it
            return View(model);
        }

        public ActionResult Home()
        {

            return RedirectToRoute("Home","Index");
        }

      
    }
}
