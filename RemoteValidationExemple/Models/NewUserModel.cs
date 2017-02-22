using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidationExemple.Models
{
    public class NewUserModel
    {
        [Remote("ValidateUserName", "Home")]
        public string Name { get; set; }

        [Remote("ValidatePassword", "Home")]
        public string Password { get; set; }
    }
}