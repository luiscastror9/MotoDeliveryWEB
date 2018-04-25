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
    public class Usuario_MotoController : Controller
    {
        private MotoDeliveryEntities2 db = new MotoDeliveryEntities2();

        // GET: Usuario_Moto
        public ActionResult Index()
        {
            var usuario_Moto = db.Usuario_Moto.Include(u => u.Usuario);
            return View(usuario_Moto.ToList());
        }

        // GET: Usuario_Moto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario_Moto usuario_Moto = db.Usuario_Moto.Find(id);
            if (usuario_Moto == null)
            {
                return HttpNotFound();
            }
            return View(usuario_Moto);
        }

        // GET: Usuario_Moto/Create
        public ActionResult Create()
        {
            ViewBag.id_moto = new SelectList(db.Usuario, "id_Usuario", "id_Usuario");
            return View();
        }

        // POST: Usuario_Moto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patente,id_moto,estado_moto")] Usuario_Moto usuario_Moto)
        {
            if (ModelState.IsValid)
            {
                db.Usuario_Moto.Add(usuario_Moto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_moto = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", usuario_Moto.id_moto);
            return View(usuario_Moto);
        }

        // GET: Usuario_Moto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario_Moto usuario_Moto = db.Usuario_Moto.Find(id);
            if (usuario_Moto == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_moto = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", usuario_Moto.id_moto);
            return View(usuario_Moto);
        }

        // POST: Usuario_Moto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patente,id_moto,estado_moto")] Usuario_Moto usuario_Moto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario_Moto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_moto = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", usuario_Moto.id_moto);
            return View(usuario_Moto);
        }

        // GET: Usuario_Moto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario_Moto usuario_Moto = db.Usuario_Moto.Find(id);
            if (usuario_Moto == null)
            {
                return HttpNotFound();
            }
            return View(usuario_Moto);
        }

        // POST: Usuario_Moto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario_Moto usuario_Moto = db.Usuario_Moto.Find(id);
            db.Usuario_Moto.Remove(usuario_Moto);
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
