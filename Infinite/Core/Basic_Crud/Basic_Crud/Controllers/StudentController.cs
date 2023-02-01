using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crud.Models;

namespace Basic_Crud.Controllers
{
    
   [Route("Start")]
    public class StudentController : Controller
    {
        //creating a refernce variable/object of the service Interface
        readonly IStudentRepository isr = null;

        //Initialize the readonly object in the constructor by Injecting
        // the service class/interface
        public StudentController(IStudentRepository repo)
        {
            isr = repo;
        }

        //Inorder to route to an Index action method of a controller, we can use the 
        //decorator Route
         [Route("Index")]
         [Route("")]
         [Route("/")]
        public JsonResult Index()
        {
            List<Student> allstudents = isr.GetAllStudents();
            return Json(allstudents);
        }
        //public IActionResult Index()
        //{
        //    List<Student> allstudents = isr.GetAllStudents();
        //    return View(allstudents);
        //}

        [Route("Details/{id?}")]
        public JsonResult GetA_Student(int sid)
        {
            Student s = isr.GetStudentById(sid);
            return Json(s);
        }

        [HttpGet]
       [Route("Insert")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Insert")]
        public IActionResult Create(Student s)
        {
            isr.Create(s);
           return View("Thanks", s);           
        }
        [HttpGet]
        [Route("Update/{id?}")]
        public IActionResult Edit(int id)
        {
            Student std = isr.GetStudentById(id);
           //Student std = isr.GetAllStudents().Where(s => s.StdId == id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        [Route("Update/{id?}")]
        public IActionResult Edit(int id, Student s)
        {
            // isr.GetAllStudents().Where(s => s.StdId == id).FirstOrDefault().StdName = s.StdName;
            // isr.GetAllStudents().Where(s => s.StdId == id).FirstOrDefault().Branch = s.Branch;
            Student updatedstudent= isr.Update(id, s);
            return RedirectToAction("updated",updatedstudent);
        }
        [Route("updated")]
        public IActionResult updated(Student s)
        {
            return View(s);
        }

    }
}
