using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MVCDITest.App_Start;
using Unity.Mvc3;

namespace MVCDITest
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Init()));
        }
    }
}
