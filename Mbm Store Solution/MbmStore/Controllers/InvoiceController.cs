using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private Repository repository = new Repository();
        // GET: Invoice
        public ActionResult Index()
        {
            ViewBag.Invoices = repository.Invoices;
            return View();
        }
    }
}