using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nvv.Lesson08CF.Models;

namespace Nvv.Lesson08CF.Controllers
{
    public class NvvBooksController : Controller
    {
        private NvvBookStore db = new NvvBookStore();

        // GET: NvvBooks
        public ActionResult NvvIndex()
        {
            var nvvBooks = db.NvvBooks.Include(n => n.nvvCategory);
            return View(nvvBooks.ToList());
        }

        // GET: NvvBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvvBook nvvBook = db.NvvBooks.Find(id);
            if (nvvBook == null)
            {
                return HttpNotFound();
            }
            return View(nvvBook);
        }

        // GET: NvvBooks/Create
        public ActionResult Create()
        {
            ViewBag.NvvCategoryId = new SelectList(db.NvvCategories, "NvvCategoryId", "NvvCategoryName");
            return View();
        }

        // POST: NvvBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NvvBookId,NvvMyProperty,NvvAuthor,NvvYear,NvvPublisher,NvvPicture,NvvCategoryId")] NvvBook nvvBook)
        {
            if (ModelState.IsValid)
            {
                db.NvvBooks.Add(nvvBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NvvCategoryId = new SelectList(db.NvvCategories, "NvvCategoryId", "NvvCategoryName", nvvBook.NvvCategoryId);
            return View(nvvBook);
        }

        // GET: NvvBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvvBook nvvBook = db.NvvBooks.Find(id);
            if (nvvBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.NvvCategoryId = new SelectList(db.NvvCategories, "NvvCategoryId", "NvvCategoryName", nvvBook.NvvCategoryId);
            return View(nvvBook);
        }

        // POST: NvvBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NvvBookId,NvvMyProperty,NvvAuthor,NvvYear,NvvPublisher,NvvPicture,NvvCategoryId")] NvvBook nvvBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nvvBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NvvCategoryId = new SelectList(db.NvvCategories, "NvvCategoryId", "NvvCategoryName", nvvBook.NvvCategoryId);
            return View(nvvBook);
        }

        // GET: NvvBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NvvBook nvvBook = db.NvvBooks.Find(id);
            if (nvvBook == null)
            {
                return HttpNotFound();
            }
            return View(nvvBook);
        }

        // POST: NvvBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NvvBook nvvBook = db.NvvBooks.Find(id);
            db.NvvBooks.Remove(nvvBook);
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
