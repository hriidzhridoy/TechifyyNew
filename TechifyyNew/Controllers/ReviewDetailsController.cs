using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TechifyyNew.Models;

namespace TechifyyNew.Controllers
{
    public class ReviewDetailsController : Controller
    {
        private techifyyEntities db = new techifyyEntities();

        // GET: ReviewDetails
        public ActionResult ReviewDetails()
        {


            /* 
             if (id == null)
             {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
             Review review = db.Reviews.Find(id);
             if (review == null)
             {
                 return HttpNotFound();
             }
             return View(review);
             */
            return View();
        }
    }
}