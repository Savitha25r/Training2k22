using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpersPrj.Models;

namespace HtmlHelpersPrj.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //1. strongly typed html helper
        public ActionResult StronglyTypedHelper()
        {
            return View();
        }

        //2. Template Helper 1
        public ActionResult TemplateHelper()
        {
            return View();
        }

        //3. Template helper 2

        public ActionResult ForModel()
        {
            return View();
        }

    }
}