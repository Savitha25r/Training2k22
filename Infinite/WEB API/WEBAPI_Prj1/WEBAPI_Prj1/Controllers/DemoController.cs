using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPI_Prj1.Models;

namespace WEBAPI_Prj1.Controllers
{
    public class DemoController : ApiController
    {
        static List<string> continents = new List<string> { "Asia", "Africa", "Antartica", "Europe", "America" };
        
        //Get : api/Demo
        public IEnumerable<string> Get()
        {
            return continents;
        }

        //Get : api/Demo/2

        public string Get(int id)
        {
            return continents[id];
        }

        //Post using an model Object
        public IEnumerable<string> Post([FromBody] Sample s)
        {
            continents.Add(s.name);
            //continents.Add(val);
            return continents;
        }

        
        [HttpPost]
        public IEnumerable<string> Addstring([FromUri] string val)
        {
            continents.Add(val);
            return continents;
        }

        //Put :api/demo/id
        public IEnumerable<string>Put(int id,[FromUri] string v)
        {
            continents[id-1] = v;
            return continents;
        }

        //delete :api/demo/id
        //this gives the contents back after deletion

        //public IEnumerable<string>Delete(int id)
        //{
        //    continents.RemoveAt(id - 1);
        //    return continents;
        //}

        //this does not reflect delete, because the delete
        //method is void
        public void Delete(int id)
        {
            continents.RemoveAt(id - 1);
        }
    }
}
