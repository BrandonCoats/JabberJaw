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
        static List<FeedBackResponse> responses = new List<FeedBackResponse>
        {
            new FeedBackResponse
            {
                actualWord = "pie",
                partofSpeech = "noun"
            },
            new FeedBackResponse
            {
                actualWord = "run",
                partofSpeech = "verb"
            },
            new FeedBackResponse
            {
                actualWord = "fast",
                partofSpeech = "adjective"
            }

        };
        // GET: FeedBack
        public ActionResult Index()
        {
            //I really like this, this is like an sql query but for a list will be super easy to convert later
           var model = 
            from r in responses
            orderby r.actualWord
            select r;
            return View(model);
        }

        // GET: FeedBack/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FeedBack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeedBack/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedBack/Edit/5
        public ActionResult Edit(string id)
        {
            //var word = responses.Single(r => r.actualWord == id);
            return View();
        }

        // POST: FeedBack/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FeedBack/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FeedBack/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
