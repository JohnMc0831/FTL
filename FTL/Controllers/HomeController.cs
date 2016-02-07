using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FTL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Support()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Support(FormCollection fc)
        {
            return View("Index");
        }
    }
}