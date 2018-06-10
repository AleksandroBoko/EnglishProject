﻿using System.Web.Routing;
using System.Web.Mvc;

namespace GameStore
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}