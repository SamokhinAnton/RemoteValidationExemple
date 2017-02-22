using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidationExemple.Controllers
{
    public class AuthorizationController : Controller
    {
        List<string> Users = new List<string>() { "aaa", "bbb", "ccc", "ddd" };

        [HttpGet]
        public JsonResult ValidateLogin(string login)
        {
            bool result = Users.Contains(login);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}