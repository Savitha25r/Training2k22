using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Day4Prj.Models
{
    public class Employee
    {
        [Required]   //(ErrorMessage ="User name is a Must")]
        [Display(Name ="Employee Name",Prompt ="Enter Employee name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Re-enter password")]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Please Enter Email")]
        [Display(Name ="Email ID")]
        //[RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
           // ErrorMessage ="Enter Email in Correct Format")]
        public string Email { get; set; }
        [Range(21,58,ErrorMessage =("Age Should Be Between 21 and 58 only"))]
        public int Age { get; set; }
    }
}