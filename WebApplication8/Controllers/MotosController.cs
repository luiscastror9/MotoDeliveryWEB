using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Datos;

namespace WebApplication8.Controllers
{
    public class MotosController : Controller
    {
        private MotoDeliveryEntities db = new MotoDeliveryEntities();

        // GET: Motos
        [Authorize]
        public ActionResult Index()
        {
            var moto = db.Moto.Include(m => m.AspNetUsers);
            return View(moto.ToList());
        }

        // GET: Motos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moto moto = db.Moto.Find(id);
            if (moto == null)
            {
                return HttpNotFound();
            }
            return View(moto);
        }

        // GET: Motos/Create
        public ActionResult Create()
        {
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: Motos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patente,Id_Usuario,modelo,registro,seguro")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                db.Moto.Add(moto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", moto.Id_Usuario);
            return View(moto);
        }

        // GET: Motos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moto moto = db.Moto.Find(id);
            if (moto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", moto.Id_Usuario);
            return View(moto);
        }

        // POST: Motos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patente,Id_Usuario,modelo,registro,seguro")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", moto.Id_Usuario);
            return View(moto);
        }

        // GET: Motos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Moto moto = db.Moto.Find(id);
            if (moto == null)
            {
                return HttpNotFound();
            }
            return View(moto);
        }

        // POST: Motos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Moto moto = db.Moto.Find(id);
            db.Moto.Remove(moto);
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
