using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Licenses()
        {
            return View();
        }
    }
}