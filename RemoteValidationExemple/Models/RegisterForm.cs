using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidationExemple.Models
{
    public class RegisterForm : IValidatableObject
    {
        [Required]
        [Remote("ValidateLogin", "Authorization")]
        public string Login { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [RegularExpression("^[a-zA-Z0-9]+$")]
        public string Pass { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Pass")]
        public string Pass2 { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [RegularExpression("^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$")]
        public string Phone { get; set; }

        [StringLength(25, MinimumLength = 2)]
        public double Stage { get; set; }

        public int Year { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (this.Year + 100 <= DateTime.Now.Year)
            {
                results.Add(new ValidationResult("Year is to small", new List<string>() { "Year" }));
            }
            return results;
        }
    }
}