using System.Web.Mvc;
using System.Web.Routing;

namespace DirectoryListing
{
    public static class RouteConfig
    {
        #region Static Methods

        #region Public Static Methods

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("_static/{*pathInfo}");

            routes.MapRoute("Zip", "_zip/{*path}", new { controller = "Home", action = "Zip", path = UrlParameter.Optional });
            routes.MapRoute("Default", "{*path}", new { controller = "Home", action = "Index", path = UrlParameter.Optional });
        }

        #endregion Public Static Methods

        #endregion Static Methods
    }
}