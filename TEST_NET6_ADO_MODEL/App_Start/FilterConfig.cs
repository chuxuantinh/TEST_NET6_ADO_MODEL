using System.Web;
using System.Web.Mvc;

namespace TEST_NET6_ADO_MODEL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
