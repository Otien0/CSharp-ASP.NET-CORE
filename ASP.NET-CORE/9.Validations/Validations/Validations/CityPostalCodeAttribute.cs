using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Validations.Models;

namespace Validations.Validations
{
    public class CityPostalCodeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            UserDetails ud = value as UserDetails;

            if (ud.City.ToLower() == "nairobi" && ud.PostalCode > 500)
                return new ValidationResult("Invalid PostalCode for Nairobi City.");

            return ValidationResult.Success;
        }
    }
}
