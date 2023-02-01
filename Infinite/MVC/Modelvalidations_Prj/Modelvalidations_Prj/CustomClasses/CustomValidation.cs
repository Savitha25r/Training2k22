using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Modelvalidations_Prj.Models;

namespace Modelvalidations_Prj.CustomClasses
{
    public class CustomValidation
    {
    }

    //creating custom validbirthdate class to validate the dob
    public sealed class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime mindt = Convert.ToDateTime("11/25/1970");
            DateTime maxdt = Convert.ToDateTime("01/25/1990");
            if (entered_dob >= mindt && entered_dob <= maxdt)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public class GenderValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public class SkillValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<CheckBox> skills_selected = value as List<CheckBox>;
            int count = skills_selected == null ? 0 : (from s in skills_selected
                                                       where s.IsChecked == true
                                                       select s).Count();
            if(count>=3)
                return ValidationResult.Success;

            else
                return new ValidationResult(ErrorMessage);
                    
        }
    }
}