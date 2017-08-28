using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace biznes.Controllers
{
    public class EvaluationsController : Controller
    {
        // GET: Evaluations
        public ActionResult Index()
        {
            return RedirectToAction("EstimationLand");
        }

        public ActionResult EstimationLand()
        {
            return View();
        }

        public ActionResult PropertyValuation()
        {
            return View();
        }

        public ActionResult EvaluationEquipment()
        {
            return View();
        }

        public ActionResult EvaluationCars()
        {
            return View();
        }
    }
}