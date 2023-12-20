using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aadharusingmodelfirst.Models;

namespace aadharusingmodelfirst.Controllers
{
    public class HomeController : Controller
    {
        private Model1Container db = new Model1Container(); 

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Aadharmodeldemoes.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aadharmodeldemo aadharmodeldemo = db.Aadharmodeldemoes.Find(id);
            if (aadharmodeldemo == null)
            {
                return HttpNotFound();
            }
            return View(aadharmodeldemo);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Aadhar_number,Name,Fathers_name,Dob,Address,Gender")] Aadharmodeldemo aadharmodeldemo)
        {
            if (ModelState.IsValid)
            {
                db.Aadharmodeldemoes.Add(aadharmodeldemo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aadharmodeldemo);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aadharmodeldemo aadharmodeldemo = db.Aadharmodeldemoes.Find(id);
            if (aadharmodeldemo == null)
            {
                return HttpNotFound();
            }
            return View(aadharmodeldemo);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Aadhar_number,Name,Fathers_name,Dob,Address,Gender")] Aadharmodeldemo aadharmodeldemo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aadharmodeldemo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aadharmodeldemo);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aadharmodeldemo aadharmodeldemo = db.Aadharmodeldemoes.Find(id);
            if (aadharmodeldemo == null)
            {
                return HttpNotFound();
            }
            return View(aadharmodeldemo);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aadharmodeldemo aadharmodeldemo = db.Aadharmodeldemoes.Find(id);
            db.Aadharmodeldemoes.Remove(aadharmodeldemo);
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
