using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvv.Lesson04.Controllers
{
    /// <summary>
    /// Author : Nguyễn Văn Vũ
    /// Class : K22CNT2
    /// </summary>
    public class NvvStudentController : Controller
    {
        // GET: NvvStudent
        public ActionResult Index()
        {
            // truyền dữ liệu từ Controler ->View
            ViewBag.fullName = "Nguyễn Văn Vũ";
            ViewData["Birthday"] = "06/04/2004";
            TempData["Phone"] = "0812056108";
            return View();
        }
        public ActionResult Details()
        {
            string nvvStr = "";
            nvvStr += "<h3> Họ và tên: Nguyễn Văn Vũ </h3>";
            nvvStr += "<p> Mã số: 2210900081";
            nvvStr += "<p>  Địa chỉ email: nguyenvanvu642004@gmail.com";

            ViewBag.Details = "nvvStr";
            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Quyền", "Ánh Ngọc", "Phương Nhi", "Linh Chi" };
            ViewBag.names = names;
            return View();
        }

        // HTMLHelper
        // GET: NvvStudent/AddNewStuden
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            // lấy dữ liệu trên form
            string fullname = form["fullname"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];

            string nvvStr = "<h3>" + fullname + "</h3>";
            nvvStr += "<p>" + masv;
            nvvStr += "<p>" + TaiKhoan;
            nvvStr += "<p>" + MatKhau;
            ViewBag.info = nvvStr;

            return View("Ketqua");
        }
    }
}