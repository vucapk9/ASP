using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nvv.Lesson10.Models;

namespace Nvv.Lesson10.Controllers
{
    public class NvvMonHocsController : Controller
    {
        private NvvK22CNT2Lesson10DbEntities db = new NvvK22CNT2Lesson10DbEntities();

        // GET: NvvMonHocs
        public ActionResult NvvIndex()
        {
            return View(db.nvvMonHoc.ToList());
        }

        // GET: NvvMonHocs/Details/5
        public ActionResult NvvDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvMonHoc nvvMonHoc = db.nvvMonHoc.Find(id);
            if (nvvMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nvvMonHoc);
        }

        // GET: NvvMonHocs/Create
        public ActionResult NvvCreate()
        {
            return View();
        }

        // POST: NvvMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvCreate([Bind(Include = "NvvMaKH,NvvTenMH,NvvSotiet")] nvvMonHoc nvvMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.nvvMonHoc.Add(nvvMonHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvvMonHoc);
        }

        // GET: NvvMonHocs/Edit/5
        public ActionResult NvvEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvMonHoc nvvMonHoc = db.nvvMonHoc.Find(id);
            if (nvvMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nvvMonHoc);
        }

        // POST: NvvMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvEdit([Bind(Include = "NvvMaKH,NvvTenMH,NvvSotiet")] nvvMonHoc nvvMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvvMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvvMonHoc);
        }

        // GET: NvvMonHocs/Delete/5
        public ActionResult NvvDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvMonHoc nvvMonHoc = db.nvvMonHoc.Find(id);
            if (nvvMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(nvvMonHoc);
        }

        // POST: NvvMonHocs/Delete/5
        [HttpPost, ActionName("NvvDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvvMonHoc nvvMonHoc = db.nvvMonHoc.Find(id);
            db.nvvMonHoc.Remove(nvvMonHoc);
            db.SaveChanges();
            return RedirectToAction("NvvIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
