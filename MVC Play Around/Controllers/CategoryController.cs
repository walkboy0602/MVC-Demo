using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Play_Around.Models;

namespace MVC_Play_Around.Controllers
{
    public class CategoryController : Controller
    {
        private DemoEntities db = new DemoEntities();

        //
        // GET: /Category/

        public ActionResult Index()
        {
            return View(db.RefCategories.ToList());
        }

        //
        // GET: /Category/Details/5

        public ActionResult Details(int id = 0)
        {
            RefCategory refcategory = db.RefCategories.Find(id);
            if (refcategory == null)
            {
                return HttpNotFound();
            }
            return View(refcategory);
        }

        //
        // GET: /Category/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Category/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RefCategory refcategory)
        {
            if (ModelState.IsValid)
            {
                db.RefCategories.Add(refcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(refcategory);
        }

        //
        // GET: /Category/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RefCategory refcategory = db.RefCategories.Find(id);
            if (refcategory == null)
            {
                return HttpNotFound();
            }
            return View(refcategory);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RefCategory refcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(refcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(refcategory);
        }

        //
        // GET: /Category/Delete/5

        public ActionResult Delete(int id = 0)
        {
            RefCategory refcategory = db.RefCategories.Find(id);
            if (refcategory == null)
            {
                return HttpNotFound();
            }
            return View(refcategory);
        }

        //
        // POST: /Category/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RefCategory refcategory = db.RefCategories.Find(id);
            db.RefCategories.Remove(refcategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}