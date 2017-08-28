using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult Index()
        {
            return RedirectToAction("Codex");
        }

        public ActionResult Codex()
        {
            return View();
        }

        public ActionResult Lex()
        {
            return View();
        }

        public ActionResult Resolutions()
        {
            return View();
        }
    }
}