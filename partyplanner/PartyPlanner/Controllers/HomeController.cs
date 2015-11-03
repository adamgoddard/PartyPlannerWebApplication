using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyPlanner.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult Index()
        {
            return RedirectToAction("NewIndex");
        }

        public ActionResult NewIndex(){
            return View("Index");
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