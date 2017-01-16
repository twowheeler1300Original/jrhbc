using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JamesRiverHBC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Club History.";
            return View();
        }

        public ActionResult ClubEvents()
        {
            ViewBag.Message = "We're heating the mash water now.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "We're heating the mash water now.";

            return View();
        }

        public ActionResult Meetings()
        {
            ViewBag.Message = "Monthly Club Meetings";

            return View();
        }
    }
}