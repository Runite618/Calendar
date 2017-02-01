using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calendar.Models;
using Calendar;
using System.Data.SqlClient;
using System.Configuration;

namespace Calendar.Controllers
{
    public class HomeController : Controller
    {
        private EventContext _db = new EventContext();

        [HttpGet]
        public ActionResult Index()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connWebOrdering"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            string selectSql = "SELECT * FROM Dates";
            SqlCommand com = new SqlCommand(selectSql, con);

            var model = new Date();

            try
            {
                con.Open();
                using (SqlDataReader read = com.ExecuteReader())
                {
                    while(read.Read())
                    {
                        model.Event = (read["Event"].ToString());
                        model._Date = Convert.ToDateTime(read["_Date"]);
                    }
                }
            }
            finally
            {
                con.Close();
            }
            return View(model);
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
        public ActionResult DatePost([Bind(Include = "ID, _Date, Event")] Date model)
        {
            _db.Entry(model).State = System.Data.Entity.EntityState.Added;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}