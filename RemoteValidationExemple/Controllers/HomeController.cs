using RemoteValidationExemple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidationExemple.Controllers
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

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View(new NewUserModel());
        }

        [HttpGet]
        public JsonResult ValidateUserName(string name)
        {
            bool result = name == "Sasha";
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult ValidatePassword(string password)
        {
            bool result = string.Equals("qwerty", password, StringComparison.OrdinalIgnoreCase);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}