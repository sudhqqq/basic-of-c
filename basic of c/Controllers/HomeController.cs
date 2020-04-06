using basic_of_c.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace basic_of_c.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            ViewData["Message"] = "message from view data";
            ViewData["currentTime"] = DateTime.Now.ToLongDateString();

            string[] fruit = { "apple", "orange", "mango" };
            ViewData["fruitarray"] = fruit;

            ViewData["sportslist"] = new List<string>()
            {
                "cricket",
                "football",
                "chess"
            };

            Employee ali = new Employee();
            ali.Empid = 1;
            ali.Empname = "ali ahemed";
            ali.Empcorse = "b.tech";

            ViewData["Employee"] = ali;
            return View();
        }
    }
}