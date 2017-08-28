using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class GeodeticsController : Controller
    {
        // GET: Geodetics
        public ActionResult Index()
        {
            return RedirectToAction("CaptureM");
        }

        public ActionResult CaptureM()
        {
            return View();
        }

        public ActionResult ExecutiveShooting()
        {
            return View();
        }

        public ActionResult GeideticsWorks()
        {
            return View();
        }

        public ActionResult TransferToNature()
        {
            return View();
        }
    }
}