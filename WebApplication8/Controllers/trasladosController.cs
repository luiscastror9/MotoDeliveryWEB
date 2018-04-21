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
    public class trasladosController : Controller
    {
        private MotoDeliveryEntities db = new MotoDeliveryEntities();

        // GET: traslados
        public ActionResult Index()
        {
            var trasladoes = db.trasladoes.Include(t => t.usuario).Include(t => t.usuario_moto);
            return View(trasladoes.ToList());
        }

        // GET: traslados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traslado traslado = db.trasladoes.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            return View(traslado);
        }

        // GET: traslados/Create
        public ActionResult Create()
        {
            ViewBag.usuario_id = new SelectList(db.usuarios, "usuario_id", "tipo_usuario");
            ViewBag.id_moto = new SelectList(db.usuario_moto, "id_moto", "id_moto");
            return View();
        }

        // POST: traslados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo_tras,usuario_id,id_moto,tarifa,calle_in,altura_in,piso_in,dep_in,calle_fn,altura_fn,piso_fn,dep_fn")] traslado traslado)
        {
            if (ModelState.IsValid)
            {
                db.trasladoes.Add(traslado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.usuario_id = new SelectList(db.usuarios, "usuario_id", "tipo_usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.usuario_moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // GET: traslados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traslado traslado = db.trasladoes.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            ViewBag.usuario_id = new SelectList(db.usuarios, "usuario_id", "tipo_usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.usuario_moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // POST: traslados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo_tras,usuario_id,id_moto,tarifa,calle_in,altura_in,piso_in,dep_in,calle_fn,altura_fn,piso_fn,dep_fn")] traslado traslado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traslado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.usuario_id = new SelectList(db.usuarios, "usuario_id", "tipo_usuario", traslado.usuario_id);
            ViewBag.id_moto = new SelectList(db.usuario_moto, "id_moto", "id_moto", traslado.id_moto);
            return View(traslado);
        }

        // GET: traslados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            traslado traslado = db.trasladoes.Find(id);
            if (traslado == null)
            {
                return HttpNotFound();
            }
            return View(traslado);
        }

        // POST: traslados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            traslado traslado = db.trasladoes.Find(id);
            db.trasladoes.Remove(traslado);
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
