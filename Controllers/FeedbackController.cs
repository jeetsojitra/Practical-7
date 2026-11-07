using practcal_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practcal_7.Controllers
{
    public class FeedbackController : Controller
    {
        public Action 
        public ActionResult create(Feedback feedback)
        {
            feedbackList.Add(feedback);
            return RedirectToAction("List");
        }
        {
            return View();
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}