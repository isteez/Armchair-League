using System.Web.Mvc;
using System.Web.Routing;

namespace ArmchairLeague
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "DraftLottery",
				url: "draftlottery",
				defaults: new { controller = "Draft", action = "Index", id = UrlParameter.Optional }
			);

			routes.MapRoute(
				name: "GetNextTeam",
				url: "draftlottery/getnextteam",
				defaults: new { controller = "Draft", action = "GetNextTeam", id = UrlParameter.Optional }
			);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
