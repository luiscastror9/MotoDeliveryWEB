using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8;

namespace WebApplication8.Controllers
{
    public class MotosController : Controller
    {
        private MotoDeliveryEntities2 db = new MotoDeliveryEntities2();

        // GET: Motos
        public ActionResult Index()
        {
            var moto = db.Moto.Include(m => m.Usuario);
            return View(moto.ToList());
        }

        // GET: Motos/Details/5
        public ActionResult Details(int? id)
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
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario");
            return View();
        }

        // POST: Motos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patente,usuario_id,modelo,registro,seguro,foto")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                db.Moto.Add(moto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", moto.usuario_id);
            return View(moto);
        }

        // GET: Motos/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", moto.usuario_id);
            return View(moto);
        }

        // POST: Motos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patente,usuario_id,modelo,registro,seguro,foto")] Moto moto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", moto.usuario_id);
            return View(moto);
        }

        // GET: Motos/Delete/5
        public ActionResult Delete(int? id)
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
        public ActionResult DeleteConfirmed(int id)
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
