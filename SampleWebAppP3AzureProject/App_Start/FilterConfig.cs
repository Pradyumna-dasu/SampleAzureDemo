using System.Web;
using System.Web.Mvc;

namespace SampleWebAppP3AzureProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
