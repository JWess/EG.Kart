using System.Web.Routing;
using EG.Kart.Presentation.Web.Controllers;
using EG.Kart.Presentation.Web.Infrastructure.NavigationRoutes;

namespace EG.Kart.Presentation.Web.App_Start
{
    public class RouteNavigationConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<HomeController>("Automatic Scaffolding", c => c.Index());

            routes.MapNavigationRoute<ExampleLayoutsController>("Example Layouts", c => c.Starter())
                  .AddChildRoute<ExampleLayoutsController>("Marketing", c => c.Marketing())
                  .AddChildRoute<ExampleLayoutsController>("Fluid", c => c.Fluid())
                ;
        }
    }
}
