using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KontraMIS4200.DAL;
using KontraMIS4200.Models;

namespace KontraMIS4200.Controllers
{
    public class appointmentDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: appointmentDetails
        public ActionResult Index()
        {
            var appointmentDetails = db.appointmentDetails.Include(a => a.Pet).Include(a => a.Vet);
            return View(appointmentDetails.ToList());
        }

        // GET: appointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.appointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Create
        public ActionResult Create()
        {
            ViewBag.petId = new SelectList(db.Pets, "petId", "name");
            ViewBag.vetId = new SelectList(db.Vets, "vetId", "firstName");
            return View();
        }

        // POST: appointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentDetailId,dateTime,petId,vetId")] appointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.appointmentDetails.Add(appointmentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.petId = new SelectList(db.Pets, "petId", "name", appointmentDetail.petId);
            ViewBag.vetId = new SelectList(db.Vets, "vetId", "firstName", appointmentDetail.vetId);
            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.appointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.petId = new SelectList(db.Pets, "petId", "name", appointmentDetail.petId);
            ViewBag.vetId = new SelectList(db.Vets, "vetId", "firstName", appointmentDetail.vetId);
            return View(appointmentDetail);
        }

        // POST: appointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentDetailId,dateTime,petId,vetId")] appointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.petId = new SelectList(db.Pets, "petId", "name", appointmentDetail.petId);
            ViewBag.vetId = new SelectList(db.Vets, "vetId", "firstName", appointmentDetail.vetId);
            return View(appointmentDetail);
        }

        // GET: appointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            appointmentDetail appointmentDetail = db.appointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // POST: appointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            appointmentDetail appointmentDetail = db.appointmentDetails.Find(id);
            db.appointmentDetails.Remove(appointmentDetail);
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
