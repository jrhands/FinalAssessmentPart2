using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalAssessmentPart2.DAL;

namespace FinalAssessmentPart2.Controllers
{
    public class CustomersController : Controller
    {
        private NorthwindDB db = new NorthwindDB();

        // GET: Customers
        public ActionResult CustomerView()
        {
            return View(db.Customers.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
