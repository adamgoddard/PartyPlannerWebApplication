using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PartyPlanner.Models;

namespace PartyPlanner.Controllers
{
    public class EntertainerController : Controller
    {
        private PartyPlannerContext db = new PartyPlannerContext();

        // GET: Entertainer
        public ActionResult Index()
        {
            return View(db.Entertainer.ToList());
        }

        // GET: Entertainer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entertainer entertainer = db.Entertainer.Find(id);
            if (entertainer == null)
            {
                return HttpNotFound();
            }
            return View(entertainer);
        }

        // GET: Entertainer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entertainer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Username,Email,Password,FirstName,LastName,Street,Town,City,PhoneNumber,IsMagician,IsClown,IsBalloonAnimals,IsPettingZoo,IsCakes,IsCatering,IsFacePainting,IsJuggling,IsDJ,IsPartyGames,IsBouncyCastle,IsPuppets,IsHennaTattoos,IsHairBraiding,IsOther")] Entertainer entertainer)
        {
            if (ModelState.IsValid)
            {
                db.Entertainer.Add(entertainer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entertainer);
        }

        // GET: Entertainer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entertainer entertainer = db.Entertainer.Find(id);
            if (entertainer == null)
            {
                return HttpNotFound();
            }
            return View(entertainer);
        }

        // POST: Entertainer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Username,Email,Password,FirstName,LastName,Street,Town,City,PhoneNumber,IsMagician,IsClown,IsBalloonAnimals,IsPettingZoo,IsCakes,IsCatering,IsFacePainting,IsJuggling,IsDJ,IsPartyGames,IsBouncyCastle,IsPuppets,IsHennaTattoos,IsHairBraiding,IsOther")] Entertainer entertainer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entertainer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entertainer);
        }

        // GET: Entertainer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entertainer entertainer = db.Entertainer.Find(id);
            if (entertainer == null)
            {
                return HttpNotFound();
            }
            return View(entertainer);
        }

        // POST: Entertainer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entertainer entertainer = db.Entertainer.Find(id);
            db.Entertainer.Remove(entertainer);
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
