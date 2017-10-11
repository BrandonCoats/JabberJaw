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

        /// <summary>
        /// Below is a temporary data chunk until i get database connected.
        /// </summary>
        /// <returns></returns>
        //static List<FeedBackResponse> responses = new List<FeedBackResponse>
        //{
        //    new FeedBackResponse
        //    {
        //        id=1,
        //        actualWord = "pie",
        //        partofSpeech = "noun"
        //    },
        //    new FeedBackResponse
        //    {
        //         id=2,
        //        actualWord = "run",
        //        partofSpeech = "verb"
        //    },
        //    new FeedBackResponse
        //    {
        //         id=3,
        //        actualWord = "fast",
        //        partofSpeech = "adjective"
        //    }

        //};
        // GET: FeedBack
        LearningDb _db = new LearningDb();
        //need to remove to see the feedback page without signing in
        [Authorize]
        public ActionResult Index()
        {

            var model = new FeedbackDetails();
            model.AllWithPartOfSpeech = _db.getAllbyPartOfSpeech("noun");
            return View(model);
        }
        public ActionResult Home()
        {

            return RedirectToRoute("Home","Index");
        }

      
    }
}
