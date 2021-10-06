using System.Web;
using System.Web.Mvc;

namespace Control_de_inventarios_HCA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
