using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using WEBAPI_Prj1.Models;

namespace WEBAPI_Prj1.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        static List<Users> userlist = new List<Users>()
        {
            new Users{ID=1,Name="Rohan", Role="Operations"},
            new Users{ID=2,Name="Vikram", Role="Admin"},
            new Users{ID=3,Name="Rahul", Role="User"},
        };

        [HttpGet]
        [Route("General")]
        public IEnumerable<Users>Get()
        {
            return userlist;
        }

        //Get using HttpResponseMessage object
        [HttpGet]
        [Route("UserHttp")]
        public HttpResponseMessage GetUserList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, userlist);
           // response.Content = new StringContent("hello All", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(10)
            };
            return response;
        }

        //implement IHttpActionResult to get users by id
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetByID(int uid)
        {
            var user = userlist.Find(x => x.ID == uid);
            if(user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet]
        [Route("GetName")]
        public IHttpActionResult GetUserByname(int pid)
        {
            string uname = userlist.Where(a => a.ID == pid).SingleOrDefault()?.Name;
            if(uname==null)
            {
                return NotFound();
            }
            return Ok(uname);
        }

        //Post 1 
        public Users Post([FromBody] Users u)
        {
            userlist.Add(u);
            return u;
        }
        
        [HttpPost]
        [Route("AllPost")]

        public List<Users> PostAll([FromBody] Users usr)
        {
            userlist.Add(usr);
            return userlist;
        }
        [HttpPost]
        
        public void UserPost([FromUri]int Id,string name,string role)
        {
            Users u = new Users();
            u.ID = Id;
            u.Name = name;
            u.Role = role;
            userlist.Add(u);
        }
        //put

        public void Put(int id,[FromBody] Users u)
        {
            userlist[id - 1] = u;
        }

        //delete
        public void Delete(int id)
        {
            userlist.RemoveAt(id - 1);
        }

    }
}
