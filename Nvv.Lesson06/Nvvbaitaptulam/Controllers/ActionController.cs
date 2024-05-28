using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Nvvbaitaptulam.Controllers
{
    public class ActionController : Controller
    {
        // GET: Photo/Upload
        public ActionResult Upload()
        {
            return View();
        }

        // POST: Photo/Upload
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                try
                {
                    string fileName = Path.GetFileName(file.FileName);
                    string path = Path.Combine(Server.MapPath("~/Content/Images"), fileName);
                    file.SaveAs(path);
                    ViewBag.Message = "Upload thành công!";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Upload không thành công: " + ex.Message;
                }
            }
            else
            {
                ViewBag.Message = "Vui lòng chọn một tập tin.";
            }
            return View();
        }

        // GET: Photo/Delete
        public ActionResult Delete(string fileName)
        {
            if (fileName == null)
            {
                return HttpNotFound();
            }

            string path = Path.Combine(Server.MapPath("~/Content/Images"), fileName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                ViewBag.Message = "Ảnh đã được xóa!";
            }
            else
            {
                ViewBag.Message = "Không tìm thấy ảnh để xóa!";
            }

            return RedirectToAction("Index", "Photo"); // Chuyển hướng về trang chính sau khi xóa ảnh
        }
    }
}

