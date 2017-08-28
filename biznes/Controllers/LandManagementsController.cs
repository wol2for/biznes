using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class LandManagementsController : Controller
    {
        // GET: LandManagements
        public ActionResult Index()
        {
            return RedirectToAction("SectionUnion");
        }

        public ActionResult SectionUnion()
        {
            return View();
        }

        public ActionResult AllocationLand()
        {
            return View();
        }

        public ActionResult PreparationDocumentationLandPlot()
        {
            return View();
        }

        public ActionResult PreparationDocumentationLandPrivatization()
        {
            return View();
        }

        public ActionResult AppointmenCadastralNumber()
        {
            return View();
        }
       
    }
}