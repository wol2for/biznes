using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return RedirectToAction("New1");
        }

        public ActionResult New1()
        {
            return View();
        }

        public ActionResult New2()
        {
            return View();
        }

        public ActionResult New3()
        {
            return View();
        }

        public ActionResult New4()
        {
            return View();
        }

        public ActionResult New5()
        {
            return View();
        }

        public ActionResult New6()
        {
            return View();
        }

        public ActionResult New7()
        {
            return View();
        }

        public ActionResult New8()
        {
            return View();
        }

        public ActionResult New9()
        {
            return View();
        }

        public ActionResult New10()
        {
            return View();
        }
    }
}