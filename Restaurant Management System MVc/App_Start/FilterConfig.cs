using System.Web;
using System.Web.Mvc;

namespace Restaurant_Management_System_MVc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
