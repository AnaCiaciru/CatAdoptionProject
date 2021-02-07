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
    public class ContactInfoesController : Controller
    {
        private CatAdoptionContext db = new CatAdoptionContext();

        // GET: ContactInfoes
        public ActionResult Index()
        {
            var contactsInfo = db.ContactsInfo.Include(c => c.Owner).Include(c => c.Region);
            return View(contactsInfo.ToList());
        }

        // GET: ContactInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactInfo = db.ContactsInfo.Find(id);
            if (contactInfo == null)
            {
                return HttpNotFound();
            }
            return View(contactInfo);
        }

        // GET: ContactInfoes/Create
        public ActionResult Create()
        {
            ViewBag.ContactInfoId = new SelectList(db.Owners, "OwnerId", "Name");
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            return View();
        }

        // POST: ContactInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactInfoId,PhoneNumber,Email,CNP,BirthYear,BirthMonth,BirthDay,GenderType,Resident,RegionId")] ContactInfo contactInfo)
        {
            if (ModelState.IsValid)
            {
                db.ContactsInfo.Add(contactInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactInfoId = new SelectList(db.Owners, "OwnerId", "Name", contactInfo.ContactInfoId);
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", contactInfo.RegionId);
            return View(contactInfo);
        }

        // GET: ContactInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactInfo = db.ContactsInfo.Find(id);
            if (contactInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactInfoId = new SelectList(db.Owners, "OwnerId", "Name", contactInfo.ContactInfoId);
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", contactInfo.RegionId);
            return View(contactInfo);
        }

        // POST: ContactInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactInfoId,PhoneNumber,Email,CNP,BirthYear,BirthMonth,BirthDay,GenderType,Resident,RegionId")] ContactInfo contactInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactInfoId = new SelectList(db.Owners, "OwnerId", "Name", contactInfo.ContactInfoId);
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", contactInfo.RegionId);
            return View(contactInfo);
        }

        // GET: ContactInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactInfo contactInfo = db.ContactsInfo.Find(id);
            if (contactInfo == null)
            {
                return HttpNotFound();
            }
            return View(contactInfo);
        }

        // POST: ContactInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactInfo contactInfo = db.ContactsInfo.Find(id);
            db.ContactsInfo.Remove(contactInfo);
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
