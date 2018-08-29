
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using System.Web.Optimization;

namespace MVCRazorApp
{
	public class MvcApplication : System.Web.HttpApplication
	{
		// TODO : Paulo Silva : Register : App_Start/RouteConfig.cs
		public static void RegisterRoutes (RouteCollection routes)
		{
			routes.IgnoreRoute ("{resource}.axd/{*pathInfo}");

			routes.MapRoute (
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = "" }
			);

		}

		// TODO : Paulo Silva : Register : App_Start/FilterConfig.cs
		public static void RegisterGlobalFilters (GlobalFilterCollection filters)
		{
			filters.Add (new HandleErrorAttribute ());
		}

		// TODO : Paulo Silva : Register : App_Start/BundleConfig.cs
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
		
		protected void Application_Start ()
		{
			AreaRegistration.RegisterAllAreas ();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);
			RegisterBundles(BundleTable.Bundles);

			// TODO : Paulo Silva : Register : App_Start/BundleConfig.cs
			// TODO : Paulo Silva : Config : <add namespace="System.Web.Optimization" /> 
			// FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			// RouteConfig.RegisterRoutes(RouteTable.Routes)
			// BundleConfig.RegisterBundles(BundleTable.Bundles);


		}
	}
}
