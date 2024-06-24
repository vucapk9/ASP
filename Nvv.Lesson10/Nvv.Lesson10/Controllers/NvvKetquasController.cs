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
    public class NvvKetquasController : Controller
    {
        private NvvK22CNT2Lesson10DbEntities db = new NvvK22CNT2Lesson10DbEntities();

        // GET: NvvKetquas
        public ActionResult NvvIndex()
        {
            return View(db.nvvKetqua.ToList());
        }

        // GET: NvvKetquas/Details/5
        public ActionResult NvvDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKetqua nvvKetqua = db.nvvKetqua.Find(id);
            if (nvvKetqua == null)
            {
                return HttpNotFound();
            }
            return View(nvvKetqua);
        }

        // GET: NvvKetquas/Create
        public ActionResult NvvCreate()
        {
            return View();
        }

        // POST: NvvKetquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvCreate([Bind(Include = "NvvMaSV,NvvMaKH,Diem")] nvvKetqua nvvKetqua)
        {
            if (ModelState.IsValid)
            {
                db.nvvKetqua.Add(nvvKetqua);
                db.SaveChanges();
                return RedirectToAction("NvvIndex");
            }

            return View(nvvKetqua);
        }

        // GET: NvvKetquas/Edit/5
        public ActionResult NvvEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKetqua nvvKetqua = db.nvvKetqua.Find(id);
            if (nvvKetqua == null)
            {
                return HttpNotFound();
            }
            return View(nvvKetqua);
        }

        // POST: NvvKetquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvvEdit([Bind(Include = "NvvMaSV,NvvMaKH,Diem")] nvvKetqua nvvKetqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvvKetqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nvvKetqua);
        }

        // GET: NvvKetquas/Delete/5
        public ActionResult NvvDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nvvKetqua nvvKetqua = db.nvvKetqua.Find(id);
            if (nvvKetqua == null)
            {
                return HttpNotFound();
            }
            return View(nvvKetqua);
        }

        // POST: NvvKetquas/Delete/5
        [HttpPost, ActionName("NvvDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            nvvKetqua nvvKetqua = db.nvvKetqua.Find(id);
            db.nvvKetqua.Remove(nvvKetqua);
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
