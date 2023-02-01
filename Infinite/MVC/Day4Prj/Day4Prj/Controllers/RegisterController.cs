using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Day4Prj.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public  ActionResult CreateRegistration()
        {
            return View();
        }

        [HttpPost,ActionName("CreateRegistration")]

        public ActionResult RegistrationPost(FormCollection frm)
        {
            string name = frm["txtname"].ToString();
            string password = frm["txtpass"].ToString();
            string city = frm["City"].ToString();
            string gender = frm["Gender"].ToString();

            bool music = Convert.ToBoolean(frm["M"].Split(',')[0]); //checked or unchecked
            bool sports= Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool arts= Convert.ToBoolean(frm["A"].Split(',')[0]);

            string interest = "";
            if (music == true)
                interest += "Music";
            if (sports == true)
                interest += "Sports";
            if (arts == true)
                interest += "Arts";

            StringBuilder sb = new StringBuilder();
            sb.Append("Your Name :" + name + "<br/>");
            sb.Append("Password is :"+ password + "<br/>" );
            sb.Append("City is :" + city + "<br/>");
            sb.Append("Gender is :" + gender + "<br/>");
            sb.Append("and Your Interests are :" + interest + "<br/>");
            return Content(sb.ToString());
        }
       
             
    }
}