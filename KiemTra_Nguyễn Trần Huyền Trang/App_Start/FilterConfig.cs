using System.Web;
using System.Web.Mvc;

namespace KiemTra_Nguyễn_Trần_Huyền_Trang
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
