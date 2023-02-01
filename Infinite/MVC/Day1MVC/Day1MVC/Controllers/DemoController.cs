using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVC.Models;

namespace Day1MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            List<string> str = TempData["store"] as List<string>
;            return View(str);
        }

        //eg 1. Normal method
        public string NormalMethod()
        {
            return "Hi All ..";
        }

        //eg 2. ContentResult
        public ContentResult ContentMethod()
        {
            //return Content("Good Evening to all of You !!");
            return Content("<p><strong>Good Evening to all..</strong></p>");
        }

        //eg 3. emptyresult
        [NonAction]
        public EmptyResult EmptyMethod()
        {
            int amount = 56000;
            float SI = (amount * 3 * 2) / 100;
            return new EmptyResult();
        }
        //eg 4. JsonResult
        public JsonResult JsonMethod()
        {
            Employee e = new Employee();
            e.ID = 10;
            e.Name = "Sunil";
            e.Age = 30;
            return Json(e,JsonRequestBehavior.AllowGet);
        }

        //eg 5. redirectresult

        public RedirectResult RedirectMethod()
        {
            return Redirect("JsonMethod");
        }

        //eg 6 Viewresult

        public ViewResult ViewMethod()
        {
            List<string> flowers = new List<string>()
            { "Roses","Lilies","Jasmines","Marigolds"};
            return View(flowers);
        }
    }
}