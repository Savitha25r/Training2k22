using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3EFPrj.Models;

namespace Day3EFPrj.Controllers
{
    public class MultiTableController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: MultiTable
        public ActionResult Index()
        {
            List<Region> region = db.Regions.ToList();
            return View(region);
        }

        //eg to view data from multiple table using navigation properties
        public ActionResult CustEmp_Ord_Details()
        {
            return View(db.Orders.ToList());
        }

        //eg to call a stored procedure
        [ActionName("ExpensiveProducts")]
        public ActionResult Proc_Expensive_Products()
        {
            return View("Proc_Expensive_Products", db.Ten_Most_Expensive_Products());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //create Post 1- passing data from view to controller using parameters
        //[HttpPost]
        //public ActionResult Create(int RegionID, string RegionDescription)
        //{
        //    Region r = new Region();
        //    r.RegionID = RegionID;
        //    r.RegionDescription = RegionDescription;
        //    db.Regions.Add(r);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //create Post 2 - passing data from view to controller using request object
        [HttpPost, ActionName("Create")]
        public ActionResult CreatePost()
        {
            Region r = new Region();
            r.RegionID = Convert.ToInt32(Request["RegionID"]);
            r.RegionDescription = Request["RegionDescription"].ToString();
            db.Regions.Add(r);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
