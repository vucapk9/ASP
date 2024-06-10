using Nvv.Lesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvv.Lesson08CF.Controllers
{
    public class NvvCategoryController : Controller
    {
        private static NvvBookStore _NvvBookStore;
        public NvvCategoryController()
        {
            _NvvBookStore = new NvvBookStore();
        }
        // GET: NvvCategory
        public ActionResult NvvIndex()
        {
            var nvvcategory = _NvvBookStore.NvvCategories.ToList();
            return View(nvvcategory);
        }
        [HttpGet]
        public ActionResult NvvCreate()
        {
            var nvvCategory = new NvvCategory();
            return View(nvvCategory);
        }
        [HttpPost]
        public ActionResult NvvCreate(NvvCategory nvvCategory)
        {
            _NvvBookStore.NvvCategories.Add(nvvCategory);
            _NvvBookStore.SaveChanges();    
            return RedirectToAction("NvvIndex");
        }
    }
}