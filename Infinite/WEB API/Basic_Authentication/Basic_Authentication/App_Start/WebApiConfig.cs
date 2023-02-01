using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Basic_Authentication.Models;

namespace Basic_Authentication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //msg
            //enabling our basic authentication globally for each request
           // config.Filters.Add(new BasicAuthenticationAttribute());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
