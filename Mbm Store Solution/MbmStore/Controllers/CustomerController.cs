using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            
            Customer c1 = new Customer("Simon", "Jakobsen", "Risdalsvej 36", "8260", "Viby J");
            c1.AddPhone("42 92 14 02");
            c1.AddPhone("N/A");
            c1.Birthdate = new DateTime(1990, 2, 1);
            ViewBag.C1 = c1;

            Customer c2 = new Customer("Helle", "Jakobsen", "Frigsvej 3", "8680", "Ry");
            c2.AddPhone("23 27 76 48");
            c2.AddPhone("N/A");
            c2.Birthdate = new DateTime(1962, 01, 01);
            ViewBag.C2 = c2;
            return View();
        }
    }
}