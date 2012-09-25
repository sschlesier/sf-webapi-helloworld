using System;
using DotNetNuke.Web.Api;

namespace MyServices
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("MyServices", "default", "{controller}/{action}", new[] {"MyServices"});
        }
    }
}
