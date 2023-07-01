﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Practical_15_Form_AUth
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
			);
		}
	}
}
