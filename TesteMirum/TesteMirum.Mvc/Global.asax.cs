﻿using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TesteMirum.Application.AutoMapper;
using TesteMirum.Ioc;

namespace TesteMirum.Mvc
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MvcAutofacConfig.RegisterAutofac();
            AutoMapperConfig.RegisterMappings();
        }
    }
}
