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
    public class TrasladosController : Controller
    {
        private MotoDeliveryEntities3 db = new MotoDeliveryEntities3();

        // GET: Traslados
        public ActionResult Index()
        {
            var traslado = db.Traslado.Include(t => t.Usuario).Include(t => t.Usuario_Moto);
            return View(traslado.ToList());
        }

        // GET: Traslados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traslado traslado = db.Traslado.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            return View(traslado);
        }

        // GET: Traslados/Create
        public ActionResult Create()
        {
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario");
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto");
            return View();
        }

        // POST: Traslados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo_tras,usuario_id,id_moto,tarifa,calle_in,calle_fn,estado_viaje")] Traslado traslado)
        {
            if (ModelState.IsValid)
            {
                db.Traslado.Add(traslado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // GET: Traslados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traslado traslado = db.Traslado.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // POST: Traslados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo_tras,usuario_id,id_moto,tarifa,calle_in,calle_fn,estado_viaje")] Traslado traslado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traslado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.usuario_id = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // GET: Traslados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traslado traslado = db.Traslado.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            return View(traslado);
        }

        // POST: Traslados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Traslado traslado = db.Traslado.Find(id);
            db.Traslado.Remove(traslado);
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
