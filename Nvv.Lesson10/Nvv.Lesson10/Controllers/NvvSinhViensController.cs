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
    public class NvvSinhViensController : Controller
    {
        private NvvK22CNT2Lesson10DbEntities db = new NvvK22CNT2Lesson10DbEntities();

        // GET: NvvSinhViens
        public ActionResult NvvIndex()
        {
            return View(db.nvvSinhVien.ToList());
        }

        // GET: NvvSinhViens/Details/5
        public ActionResult NvvDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvSinhVien nvvSinhVien = db.nvvSinhVien.Find(id);
            if (nvvSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nvvSinhVien);
        }

        // GET: NvvSinhViens/Create
        public ActionResult NvvCreate()
        {
            return View();
        }

        // POST: NvvSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvCreate([Bind(Include = "NvvMaSV,NvvHoSV,NvvTenSV,NvvPhai,NvvNgaySinh,NvvNoiSinh,NvvMaKH,NvvHocBong,NvvDiemTrungBinh")] nvvSinhVien nvvSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.nvvSinhVien.Add(nvvSinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nvvSinhVien);
        }

        // GET: NvvSinhViens/Edit/5
        public ActionResult NvvEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvSinhVien nvvSinhVien = db.nvvSinhVien.Find(id);
            if (nvvSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nvvSinhVien);
        }

        // POST: NvvSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvEdit([Bind(Include = "NvvMaSV,NvvHoSV,NvvTenSV,NvvPhai,NvvNgaySinh,NvvNoiSinh,NvvMaKH,NvvHocBong,NvvDiemTrungBinh")] nvvSinhVien nvvSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvvSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvvSinhVien);
        }

        // GET: NvvSinhViens/Delete/5
        public ActionResult NvvDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvSinhVien nvvSinhVien = db.nvvSinhVien.Find(id);
            if (nvvSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nvvSinhVien);
        }

        // POST: NvvSinhViens/Delete/5
        [HttpPost, ActionName("NvvDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvvSinhVien nvvSinhVien = db.nvvSinhVien.Find(id);
            db.nvvSinhVien.Remove(nvvSinhVien);
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
