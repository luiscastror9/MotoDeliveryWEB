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
    public class FacturasController : Controller
    {
        private MotoDeliveryEntities3 db = new MotoDeliveryEntities3();

        // GET: Facturas
        public ActionResult Index()
        {
            var factura = db.Factura.Include(f => f.Traslado).Include(f => f.Usuario).Include(f => f.Usuario_Moto);
            return View(factura.ToList());
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            ViewBag.codigo_viaje = new SelectList(db.Traslado, "codigo_tras", "tarifa");
            ViewBag.cliente = new SelectList(db.Usuario, "id_Usuario", "id_Usuario");
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto");
            return View();
        }

        // POST: Facturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "num_factura,codigo_viaje,cliente,id_moto,fecha,importe,estado_pago")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Factura.Add(factura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.codigo_viaje = new SelectList(db.Traslado, "codigo_tras", "tarifa", factura.codigo_viaje);
            ViewBag.cliente = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", factura.cliente);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", factura.id_moto);
            return View(factura);
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            ViewBag.codigo_viaje = new SelectList(db.Traslado, "codigo_tras", "tarifa", factura.codigo_viaje);
            ViewBag.cliente = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", factura.cliente);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", factura.id_moto);
            return View(factura);
        }

        // POST: Facturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "num_factura,codigo_viaje,cliente,id_moto,fecha,importe,estado_pago")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(factura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.codigo_viaje = new SelectList(db.Traslado, "codigo_tras", "tarifa", factura.codigo_viaje);
            ViewBag.cliente = new SelectList(db.Usuario, "id_Usuario", "id_Usuario", factura.cliente);
            ViewBag.id_moto = new SelectList(db.Usuario_Moto, "id_moto", "id_moto", factura.id_moto);
            return View(factura);
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Factura factura = db.Factura.Find(id);
            if (factura == null)
            {
                return HttpNotFound();
            }
            return View(factura);
        }

        // POST: Facturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Factura factura = db.Factura.Find(id);
            db.Factura.Remove(factura);
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
