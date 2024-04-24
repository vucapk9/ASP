using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai3._1.Controllers
{
    public class NVVstudentController : Controller
    {
        // GET: NVVstudent
        public ActionResult Index()
        {
            // dữ liệu từ viewdata
            ViewData["msg"] = "ViewData - Nguyễn Văn Vũ";
            ViewData["time"] = DateTime.Now.ToString("hh.mm.ss dd//MM.yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            // sử dụng ViewBag
            // lưu trữ giá trị đơn
            ViewBag.titleName= "Danh sách học viên - Nguyễn Văn Vũ";

            // giá trị là một tập hợp 
            string[] names = { "Phạm Quyền", "Phương Thanh", "Nguyễn Ngọc", "Phương Linh" };
            ViewBag.list = names;

            //giá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name = "Vũ Vũ",
                Age =45
            };
            ViewBag.Student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}