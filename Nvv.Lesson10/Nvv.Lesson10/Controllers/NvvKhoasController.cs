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
    public class NvvKhoasController : Controller
    {
        private NvvK22CNT2Lesson10DbEntities db = new NvvK22CNT2Lesson10DbEntities();

        // GET: NvvKhoas
        public ActionResult NvvIndex()
        {
            return View(db.nvvKhoa.ToList());
        }

        // GET: NvvKhoas/Details/5
        public ActionResult NvvDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKhoa nvvKhoa = db.nvvKhoa.Find(id);
            if (nvvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvvKhoa);
        }

        // GET: NvvKhoas/Create
        public ActionResult NvvCreate()
        {
            return View();
        }

        // POST: NvvKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvCreate([Bind(Include = "NvvMaKH,NvvTenKH")] nvvKhoa nvvKhoa)
        {
            if (ModelState.IsValid)
            {
                db.nvvKhoa.Add(nvvKhoa);
                db.SaveChanges();
                return RedirectToAction("NvvIndex");
            }

            return View(nvvKhoa);
        }

        // GET: NvvKhoas/Edit/5
        public ActionResult NvvEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKhoa nvvKhoa = db.nvvKhoa.Find(id);
            if (nvvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvvKhoa);
        }

        // POST: NvvKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvEdit([Bind(Include = "NvvMaKH,NvvTenKH")] nvvKhoa nvvKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvvKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvvKhoa);
        }

        // GET: NvvKhoas/Delete/5
        public ActionResult NvvDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKhoa nvvKhoa = db.nvvKhoa.Find(id);
            if (nvvKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nvvKhoa);
        }

        // POST: NvvKhoas/Delete/5
        [HttpPost, ActionName("NvvDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvvKhoa nvvKhoa = db.nvvKhoa.Find(id);
            db.nvvKhoa.Remove(nvvKhoa);
            db.SaveChanges();
            return RedirectToAction("Index");
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
