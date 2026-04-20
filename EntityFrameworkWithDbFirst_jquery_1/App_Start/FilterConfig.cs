using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkWithDbFirst_jquery_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
