using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Nvv.lesson02.Controllers
{
    public class NvvProductsController : Controller
    {
        // GET: NvvProducts
        public ActionResult Index()
        {
            ViewBag.name = "Nguyễn Văn Vũ - 2210900081";
            return View();
        }
        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string GetName()
        {
            return ("Nguyễn Văn Vũ - 2210900081");
        }
        public JsonResult ListName()
        {
            string[] name = { "Ngọc", " Dũng", "Quyền", "Lợi" };
            return Json(name, JsonRequestBehavior.AllowGet);
        }
    }
}