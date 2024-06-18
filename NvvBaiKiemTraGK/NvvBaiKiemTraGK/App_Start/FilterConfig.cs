using System.Web;
using System.Web.Mvc;

namespace NvvBaiKiemTraGK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
