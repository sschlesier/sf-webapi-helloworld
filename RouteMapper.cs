using System;
using DotNetNuke.Web.Api;

namespace MyServices
{
    class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("MyServices", "{controller}/{action}", new[] {"MyServices"});
        }
    }
}
