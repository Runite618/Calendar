using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calendar.Models;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Date()
        {
            var model = new Date();
            return View(model);
        }

        [HttpPost]
        public ActionResult Date(Date model)
        {
            string _event = model.Event;
            DateTime releaseDate = model.ReleaseDate;

            return View(_event, releaseDate);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}