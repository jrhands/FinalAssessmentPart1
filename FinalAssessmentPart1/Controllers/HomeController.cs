using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalAssessmentPart1.Models;

namespace FinalAssessmentPart1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult About(Calculator model)
        {
            if (model.FirstNum >= 1 && model.FirstNum <= 1000 && model.SecondNum >= 1 && model.SecondNum <= 1000)
            {
                return RedirectToAction("Result", model);
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Result(Calculator model)
        {
            ViewBag.Message = $"{model.FirstNum + model.SecondNum}";
            return View();
        }
    }
}