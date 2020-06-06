using System.Web;
using System.Web.Mvc;

namespace TestApp_CICD_Appservice
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
