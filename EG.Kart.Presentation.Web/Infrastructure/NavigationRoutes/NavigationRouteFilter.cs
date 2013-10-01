using System.Web.Routing;

namespace EG.Kart.Presentation.Web.Infrastructure.NavigationRoutes
{
    public class NavigationRouteFilter : INavigationRouteFilter
    {
        public bool ShouldRemove(Route route)
        {
            return true;
        }
    }
}
