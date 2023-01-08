using System.Web.Mvc;
using System.Web.Routing;

namespace bootcoin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Admin",
                url: "Admin/{action}",
                defaults: new { controller="Admin", action = "Index" }
            );

            routes.MapRoute(
                name: "Trainee",
                url: "Trainee/{action}",
                defaults: new {controller="Trainee", action = "Index"}
            );

            routes.MapRoute(
                name: "Debug",
                url: "Debug/{action}",
                defaults: new { controller = "Debug", action = "Index"}
            );

            routes.MapRoute(
                name: "Exception",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
