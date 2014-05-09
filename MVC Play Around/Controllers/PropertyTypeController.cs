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
    public class PropertyTypeController : Controller
    {
        private DemoEntities db = new DemoEntities();

        //
        // GET: /PropertyType/

        public ActionResult Index()
        {
            return View(db.PropertyTypes.ToList());
        }

        //
        // GET: /PropertyType/Details/5

        public ActionResult Details(int id = 0)
        {
            PropertyType propertytype = db.PropertyTypes.Find(id);
            if (propertytype == null)
            {
                return HttpNotFound();
            }
            return View(propertytype);
        }

        //
        // GET: /PropertyType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PropertyType/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PropertyType propertytype)
        {
            if (ModelState.IsValid)
            {
                db.PropertyTypes.Add(propertytype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propertytype);
        }

        //
        // GET: /PropertyType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PropertyType propertytype = db.PropertyTypes.Find(id);
            if (propertytype == null)
            {
                return HttpNotFound();
            }
            return View(propertytype);
        }

        //
        // POST: /PropertyType/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PropertyType propertytype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propertytype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propertytype);
        }

        //
        // GET: /PropertyType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PropertyType propertytype = db.PropertyTypes.Find(id);
            if (propertytype == null)
            {
                return HttpNotFound();
            }
            return View(propertytype);
        }

        //
        // POST: /PropertyType/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PropertyType propertytype = db.PropertyTypes.Find(id);
            db.PropertyTypes.Remove(propertytype);
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