using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2Views_Prj.Models;

namespace Day2Views_Prj.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //eg 3: calling another view of the same controller along with a model
        public ActionResult Index()
        {
            List<Department> deptlist = new List<Department>();
            deptlist.Add(new Department { Did = 10, Deptname = "CSE" });
            deptlist.Add(new Department { Did = 20, Deptname = "ECE" });
            deptlist.Add(new Department { Did = 30, Deptname = "IT" });
            deptlist.Add(new Department { Did = 40, Deptname = "EEE" });
            return View("DepartmentList",deptlist);
           // return View(deptlist);
        }

        //eg : 1. View Data based on a Model object
        public ActionResult DisplayEmployee()
        {
            Employee employee = new Employee() { Eid = 100, Ename = "Monisha", Salary = 45000 };
            return View(employee);
        }

        //eg 2. View based on a list of employee object
        public ActionResult EmployeeList()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{Eid=100,Ename="Swapna",Salary=47000},
                new Employee{Eid=101, Ename="Suresh",Salary=47000},
                 new Employee{Eid=102,Ename="Ajay",Salary=48000},
                new Employee{Eid=103, Ename="Aruna",Salary=49000},
            };
            return View(emplist);
        }

        // eg 3. action method/view that is being called by the Index()

        public ActionResult DepartmentList(List<Department> dlist)
        {
            return View(dlist);
        }

        //eg. 4 calling view of another controller
        public ActionResult CallAbout_OfHome()
        {
            return View("~/Views/Home/About.cshtml");           
        }

        //eg 5. calling action method of another controller
        public ActionResult Actionmethod_anothercontroller()
        {
             return RedirectToAction("About", "Home");
        }

        //eg 6. Renaming a view of an action method
        [ActionName("ShowData")]
        public ActionResult TestMethod()
        {
            // return View("TestMethod"); // if view name is different from action name
            return View(); //if the view name is same as that of an action name
        }
    }
}