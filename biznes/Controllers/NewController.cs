using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return RedirectToAction("New");
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }

        
    }
}