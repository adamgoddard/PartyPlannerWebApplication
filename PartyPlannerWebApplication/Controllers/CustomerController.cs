using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyPlannerWebApplication.Models;

namespace PartyPlannerWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        CustomerContext db = new CustomerContext();

        public ActionResult Index()
        {
            return View(db.tblCustomers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            Console.Write("method called");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblCustomer customer)
        {
            if (ModelState.IsValid)
            {
                db.tblCustomers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        
    }

}
    

