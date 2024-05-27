using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab05._1.Controllers
{
    public class NvvMemberController : Controller
    {
        // GET:/Member/CreateOne
        public ActionResult CreateOne()
        {
            return View();
        }
        //POST:/Member/CreateOne

        [HttpPost]

        public ActionResult CreateOne(Member m)
        {
            //chuyển dữ liệu nhận được với View Details
            return View("Details", m);
        }
        //GET:/Member/CreateTwo
        public ActionResult CreateTwo()
        {
            return View();
        }
        //POST:/Member/CreateTwo

        [HttpPost]

        public ActionResult CreateTwo(Member m)
        {
            //kiểm tra trống các trường và thong báo lỗi với view
            if (m.Id == null)
            {
                ViewBag.error = "hãy nhập mã số";
                return View();
            }
            if (m.Username == null)
            {
                ViewBag.error = "hãy nhập tên đăng nhập";
                return View();
            }
            if (m.FullName == null)
            {
                ViewBag.error = "hãy nhập tên họ và tên";
                return View();
            }
            if (m.Age == null)
            {
                ViewBag.error = "hãy nhập tuổi";
                return View();
            }
            if (m.Email == null)
            {
                ViewBag.error = "hãy nhập Email";
                return View();
            }
            //mẫu kiểm tra email
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za- z](2,4)";
            if

            (!System.Text.RegularExpressions.Regex.IsMatch(m.Email, regexPattern))

            {

                ViewBag.error = "hãy nhập định dạng";

                return View();

            }
            //nếu không xảy ra lỗi thì chuyển dữ liệu tới view details
            return View("Details", m);
        }
        // get: /member/createthree
        public ActionResult CreateThreee() 
        {
            return View();
        }
        //post: member/createthree
        [HttpPost]
        public ActionResult CreateThree(Member m)
        {
            //nếu trạng thái dữ liệu của model hợp lệ thì chuyển dữ liệu tới View Details
            if (ModelState.IsValid)
                return View();
            else
                return View("Details", m);
            return View();// quay lại view three để báo lỗi
        }
        // get: /member/Details
        public ActionResult Details()
        {
            return View();
        }

    }
}