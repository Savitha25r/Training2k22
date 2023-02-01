using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Modelvalidations_Prj.CustomClasses;

namespace Modelvalidations_Prj.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name ="Applicant Name")]
        public string name { get; set; }
        [Range(3,10,ErrorMessage ="Experience must be from 3 to 10 Years")]
        [Display(Name ="Years Of Experience")]
        public int experience { get; set; }
        [Display(Name ="DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage="DOB should be between 01-25-1970 & 01-25-1990")]
        public DateTime birthdate { get; set; }
        [Required]
        [Display(Name ="Email ID")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$",
            ErrorMessage ="Invalid Email")]
        public string email { get; set; }
        [GenderValidation(ErrorMessage="Select Your Gender")]
        public string Gender { get; set; }
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$",
            ErrorMessage ="Salary Should be like 6000.50")]
        [Display(Name ="Expected Salary")]
        public decimal expsal { get; set; }
        [SkillValidation(ErrorMessage="Select atleast 3 skills")]
        public List<CheckBox> Skills { get; set; }
        [Required]
        [Display(Name ="Do You Have Passport ?")]
        public string HavePassport { get; set; }
    }
}