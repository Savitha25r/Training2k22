using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Basic_Authentication.Models;

namespace Basic_Authentication.Controllers
{
    //controller level authentication[BasicAuthentication]
    public class EmployeeController : ApiController
    {
        //authentication at action/method level
        [BasicAuthentication]
        public HttpResponseMessage GetEmployees()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            var emplist = new EmployeeBL().GetEmployees();
            switch(username.ToLower())
            {
                case "maleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        emplist.Where(e => e.Gender.ToLower() == "male").ToList());
                case "femaleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        emplist.Where(e => e.Gender.ToLower() == "female").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}
