using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3EFPrj.Models;

namespace Day3EFPrj.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        //returning the scaffolded view of the categories
        public ActionResult Index()
        {
            return RedirectToAction("GetCategoryScaffolded");          
        }

        //eg 1. Fetch Data from Category table
        public ActionResult GetCategoryDetails()
        {
            List<Category> category = db.Categories.ToList();
            return View(category);
        }

        // 2. fetch data from category table and use a scaffolded view to display data
        public ActionResult GetCategoryScaffolded()
        {
            List<Category> cat = db.Categories.ToList();
            return View(cat);
        }

        //eg 3. Using Query Syntax to get category names sorted
        public ActionResult GetCat_ByName()
        {
            List<string> catname = (from c in db.Categories
                                    orderby c.CategoryName
                                    select c.CategoryName).ToList();
            return View(catname);
        }

        //eg 4. Using method syntax to get category names sorted

        public ActionResult GetCat_ByMethod()
        {
            IEnumerable<string> catname = (db.Categories.OrderBy(c => c.CategoryName).Select(
                c1 => c1.CategoryName)).ToList();
            return View(catname);
        }
        
        //CRUD operations with Category Object

        //1. inserting a new record
       [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Create(Category c)
        {
            db.Categories.Add(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffolded");
        }

        //2. Get Details of a category Id
        public ActionResult Details(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

       // 3. Edit category
       [HttpGet]
        public ActionResult Edit(int id)
        {
            Category cat = db.Categories.Find(id);
            return View(cat);
        }

        //post of edit
        public ActionResult Edit(Category c)
        {
            Category cat = db.Categories.Find(c.CategoryID);//getting before update -data
            cat.CategoryName = c.CategoryName;
            cat.Description = c.Description;
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffolded");
        }

        //delete a category
        public ActionResult Delete(int id)
        {
            Category c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("GetCategoryScaffolded");
        }
    }
}