using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calendar.Models;
using Calendar;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private EventContext _db = new EventContext();

        public ActionResult Index()
        {
            return View();
        }

        public Guid generateId()
        {
            return Guid.NewGuid();
        }

        [HttpGet]
        public ActionResult Date()
        {
            var model = new Date()
            {
                Id = generateId()
            };
            return View(model);
        }

        [HttpPost, ActionName("Date")]
        public ActionResult DatePost([Bind(Include="ID, ReleaseDate, Event")] Date model)
        {
            _db.Entry(model).State = System.Data.Entity.EntityState.Added;
            _db.SaveChanges();
            return RedirectToAction("Index");
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