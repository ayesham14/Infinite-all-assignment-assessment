using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cca_mvc111.Controllers
{
    public class CodeController : Controller
    {
        public northwindEntities db = new northwindEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GermanyPpl()
        {
            var germanyppl = db.Customers
                .Where(c => c.Country == "Germany").ToList();
            return View(germanyppl);
        }

        public ActionResult GetCustomerDetails()
        {
            var customer = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();

            return View(customer);
        }
    }
}