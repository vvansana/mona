using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MonaLisaWebApi.Context;
using MultipartDataMediaFormatter;
using MultipartDataMediaFormatter.Infrastructure;
using System.Net.Http.Formatting;

namespace MonaLisaWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Enable posting of complex objects
            GlobalConfiguration.Configuration.Formatters.Add(new FormMultipartEncodedMediaTypeFormatter(new MultipartFormatterSettings()));
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            //make sure EF migrations is disabled
            Database.SetInitializer<DatabaseContext>(null);
        }
    }
}
