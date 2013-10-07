using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using EG.Kart.Presentation.Web.App_Start;

namespace EG.Kart.Presentation.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
            RouteNavigationConfig.RegisterRoutes(RouteTable.Routes);
            IocConfig.Configure();
        }
    }
}