using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JabberJaw.Controllers
{
    public class ApprovedController : Controller
    {
        // GET: Approved
        //[HttpGet], post, lets you differentioat between similarly named  actions 
        //good for sign in garbage later. 
        //Action filters very important : restrict actions to specific users 
        //format:
        public ActionResult Search(string word)
        {
            var message = Server.HtmlEncode(word);
            //first one is action , second param finds the controller
            //return RedirectToAction("Index", "Home");
            //return file(My File)
            //retruns a file like a pdf or text file
            //returns Json({new message = message, name = "Brandon" }, JsonRequestBehavior.AllowGet)
            //returns Json serilization of abject and my name
            return View(word);
        }
    }
}