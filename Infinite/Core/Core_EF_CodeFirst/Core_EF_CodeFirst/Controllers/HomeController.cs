using Core_EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core_EF_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository employeerepo;

        public HomeController(ILogger<HomeController> logger,IEmployeeRepository repo)
        {
            _logger = logger;
            employeerepo = repo;
        }

        public IActionResult Index()
        {
            var empmodel = employeerepo.GetAllEmployees();
            return View(empmodel);
        }
       // [ActionName("Create")]
        public ViewResult AddEmployee()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddEmployee(Employee emp)
        {
            employeerepo.AddEmployee(emp);
            return RedirectToAction("Index");
        }
        [ActionName("Details")]
        public IActionResult GetEmployeeById(int id)
        {
            Employee e = employeerepo.GetEmployeeById(id);
            return View("GetEmployeeById",e);
        }
            
        public IActionResult Edit(int id)
        {
            Employee emp = employeerepo.GetEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            employeerepo.UpdateEmployee(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            employeerepo.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
