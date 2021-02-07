using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatAdoption.Data;
using CatAdoption.Models;

namespace CatAdoption.Controllers
{
    public class CatTypesController : Controller
    {
        private CatAdoptionContext db = new CatAdoptionContext();

        // GET: CatTypes
        public ActionResult Index()
        {
            return View(db.CatTypes.ToList());
        }

        // GET: CatTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatType catType = db.CatTypes.Find(id);
            if (catType == null)
            {
                return HttpNotFound();
            }
            return View(catType);
        }

        // GET: CatTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CatTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Breed,Color")] CatType catType)
        {
            if (ModelState.IsValid)
            {
                db.CatTypes.Add(catType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catType);
        }

        // GET: CatTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatType catType = db.CatTypes.Find(id);
            if (catType == null)
            {
                return HttpNotFound();
            }
            return View(catType);
        }

        // POST: CatTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Breed,Color")] CatType catType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catType);
        }

        // GET: CatTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CatType catType = db.CatTypes.Find(id);
            if (catType == null)
            {
                return HttpNotFound();
            }
            return View(catType);
        }

        // POST: CatTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CatType catType = db.CatTypes.Find(id);
            db.CatTypes.Remove(catType);
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
