using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SayMyName
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("register", "register", new { controller = "slave", action = "register" });
			routes.MapRoute("snippet", "snippet", new { controller = "slave", action = "snippet" });

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "master", action = "index", id = UrlParameter.Optional }
			);
		}
	}
}