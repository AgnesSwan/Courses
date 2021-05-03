using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Courses
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Konfiguracja i usługi składnika Web API

            // Trasy składnika Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Enable CORS for the Vue App
            var cors = new EnableCorsAttribute("http://localhost:8080", "*", "*");
            config.EnableCors(cors);
        }
    }
}
