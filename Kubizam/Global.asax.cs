using Kubizam.Models;
using System.Data.Entity;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Kubizam
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            #if DEBUG
                if (WebConfigurationManager.AppSettings["Seed"] == "true")
                {
                    Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Kubizam.Migrations.Configuration>());
                }
            #endif
        }
    }
}
