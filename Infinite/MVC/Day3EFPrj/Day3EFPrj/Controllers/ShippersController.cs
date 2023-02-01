using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3EFPrj.Models;

namespace Day3EFPrj.Controllers
{
    public class ShippersController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Shippers
        public ActionResult Index()
        {
            return View(ne.Shippers.ToList());
        }

        [HttpGet]
        public ActionResult CreateShipper()
        {
            return View();
        }

        //  1. passing data from view to controller using Model Object
        [HttpPost]
        //public ActionResult CreateShipper(Shipper s)
        //{
        //ne.Shippers.Add(s);
        //ne.SaveChanges();
        //return RedirectToAction("Index");
        //}

        //2. passing data from view to controller using formscollection
        public ActionResult CreateShipper(FormCollection frm)
        {
            Shipper s = new Shipper();
            s.ShipperID = Convert.ToInt32(frm["ShipperID"]);
            s.CompanyName = frm["CompanyName"].ToString();
            s.Phone = frm["Phone"].ToString();
            ne.Shippers.Add(s);
            ne.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}