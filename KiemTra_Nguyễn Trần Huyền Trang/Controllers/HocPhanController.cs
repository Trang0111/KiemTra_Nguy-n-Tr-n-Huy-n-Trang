using KiemTra_Nguyễn_Trần_Huyền_Trang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KiemTra_Nguyễn_Trần_Huyền_Trang.Controllers
{
    public class HocPhanController : Controller
    {
        // GET: HocPhan

        MyDataDataContext data = new MyDataDataContext();
        public ActionResult DanhSachHocPhan()
        {
            var all_hocphan = from ss in data.HocPhans select ss;
            return View(all_hocphan);
        }
    }
}