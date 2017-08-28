using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Geodetic");
        }

        public ActionResult LandManagement()
        {
            return View();
        }

        public ActionResult Geodetic()
        {
            return View();
        }

        public ActionResult Evaluation()
        {
            return View();
        }

    }
}