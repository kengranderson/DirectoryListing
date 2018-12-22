using System.Web.Mvc;
using System.Web.Routing;

namespace DirectoryListing
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region Methods

        #region Protected Methods

        protected void Application_Start()
        {
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        #endregion Protected Methods

        #endregion Methods
    }
}