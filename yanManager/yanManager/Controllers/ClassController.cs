using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XireManager.Models;

namespace XireManager.Controllers
{
    public class ClassController : Controller
    {
        private XireManagerEntities db = new XireManagerEntities();

        //
        // GET: /Class/

        public ActionResult Index()
        {
            return View(db.Classes.ToList());
        }

        //
        // GET: /Class/Details/5

        public ActionResult Details(int id = 0)
        {
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        //
        // GET: /Class/Create

        public ActionResult Create()
        {
            var teachers = db.Teachers.ToList();

            ViewBag.Teacher = teachers;
            
            return View();
        }

        //
        // POST: /Class/Create

        [HttpPost]
        public ActionResult Create(Class @class)
        {
            if (ModelState.IsValid)
            {
                db.Classes.Add(@class);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(@class);
        }

        //
        // GET: /Class/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        //
        // POST: /Class/Edit/5

        [HttpPost]
        public ActionResult Edit(Class @class)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@class).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@class);
        }

        //
        // GET: /Class/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Class @class = db.Classes.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        //
        // POST: /Class/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Class @class = db.Classes.Find(id);
            db.Classes.Remove(@class);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ShowCourseManagement(int id)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}