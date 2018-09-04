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
    public class OrdersController : Controller
    {
        private NorthwindDB db = new NorthwindDB();

        public ActionResult OrderView(string searchString)
        {
            var orders = from o in db.Orders select o;

            if (!String.IsNullOrEmpty(searchString))
            {
                orders = orders.Where(o => o.ShipCity.Contains(searchString));
            }

            return View(orders.ToList());
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
