using System.Web.Mvc;

namespace BeautyGoddess.Utilities
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html, string actionName, string controllerName)
        {
            var routeData = html.ViewContext.RouteData;
            var routeActionName = (string)routeData.Values["action"];
            var routeControllerName = (string)routeData.Values["controller"];
            var returnActive = controllerName == routeControllerName && actionName == routeActionName;
            return returnActive ? "active" : "";
        }
    }
}