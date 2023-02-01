using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day4Prj.Models;
using System.Text.RegularExpressions;

namespace Day4Prj.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee e)
        {
            if(string.IsNullOrEmpty(e.UserName))
            {
                ModelState.AddModelError("UserName", "Please enter Name");
            }
            if (!string.IsNullOrEmpty(e.Email))
            {
                string emailexp = @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$";
                Regex re = new Regex(emailexp);
                if (!re.IsMatch(e.Email))
                {
                    ModelState.AddModelError("Email", "Enter Email in correct Format");
                }
            }
                if(ModelState.IsValid)
                {
                    //db.Employees.Add(e)
                    //db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
        }
    }
       
}
