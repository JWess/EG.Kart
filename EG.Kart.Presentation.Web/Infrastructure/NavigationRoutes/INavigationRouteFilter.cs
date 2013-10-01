using System.Web.Routing;

namespace EG.Kart.Presentation.Web.Infrastructure.NavigationRoutes
{
    public interface INavigationRouteFilter
    {
        bool  ShouldRemove(Route navigationRoutes);
    }
}
