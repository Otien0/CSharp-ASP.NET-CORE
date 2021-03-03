using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Validations.Models;
using Validations.Validations;

namespace Validations.Validations
{
    public class CityAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            var ud = (UserDetails)validationContext.ObjectInstance;

            if (ud.City == null)
                return new ValidationResult("City cannot be null");

            if (ud.City.ToLower().Equals("nairobi") || ud.City.ToLower().Equals("kisumu"))
                return ValidationResult.Success;

            return new ValidationResult("City can only be either Nairobi or Kisumu");
        }



    }
}
