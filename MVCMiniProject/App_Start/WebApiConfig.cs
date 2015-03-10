using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVCMiniProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ProbabilityCalculatorApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
