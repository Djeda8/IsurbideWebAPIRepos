using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace IsurbideWebAPI.Configuration
{
    public class IsurbideWebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //   name: "ApiUsers",
            //   routeTemplate: "api/{controller}/{login}",
             //  defaults: new { login = RouteParameter.Optional }
           //);
        }
    }
}