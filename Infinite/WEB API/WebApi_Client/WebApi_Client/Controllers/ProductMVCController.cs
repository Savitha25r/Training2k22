using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_Client.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace WebApi_Client.Controllers
{
    public class ProductMVCController : Controller
    {
        // GET: ProductMVC
        public ActionResult Index()
        {
            return View();
        }

        //action method that is to consume the web api get
       // [AllowAnonymous]
        public ActionResult Display()
        {
            IEnumerable<MVCProductModel> prodlist = null;
            using(var webclient=new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44387/api/");
                var responsetask = webclient.GetAsync("product");
                responsetask.Wait();
                var result = responsetask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var resultdata = result.Content.ReadAsStringAsync().Result;
                    prodlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(resultdata);
                }
                else
                {
                    prodlist = Enumerable.Empty<MVCProductModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured.. Try Later");
                }
                return View(prodlist);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
       // [Authorize]
        public ActionResult Create(MVCProductModel prod)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44387/api/");
                var posttask = webclient.PostAsJsonAsync<MVCProductModel>("product", prod);
                posttask.Wait();
                var dataresult = posttask.Result;
                if(dataresult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
            }
            ModelState.AddModelError(string.Empty, "Some Error Occured..");
            return View(prod);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCProductModel product = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44387/api/");

                var responsetask = client.GetAsync("product/"+id).Result;
                
                if (responsetask.IsSuccessStatusCode)
                {
                    var resultdata = responsetask.Content.ReadAsStringAsync().Result;
                    product = JsonConvert.DeserializeObject<MVCProductModel>(resultdata);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
            }
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductID,ProdName,Price,QtyAvailable")] MVCProductModel product)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44387/api/");
                    var response = await client.PutAsJsonAsync("product/edit", product);
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Display");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                    }
                }
                return RedirectToAction("Index");
            }
            return View(product);
        }


    }
}