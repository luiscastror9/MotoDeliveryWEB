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
    public class UsersDataController : Controller
    {
        private MotoDeliveryEntities db = new MotoDeliveryEntities();

        // GET: UsersData
        public ActionResult Index()
        {
            var userData = db.UserData.Include(u => u.AspNetUsers);
            return View(userData.ToList());
        }

        // GET: UsersData/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserData userData = db.UserData.Find(id);
            if (userData == null)
            {
                return HttpNotFound();
            }
            return View(userData);
        }

        // GET: UsersData/Create
        public ActionResult Create()
        {
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id");
            return View();
        }

        // POST: UsersData/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Usuario,nombre,apellido,pais,doc_tipo,num_doc,f_nac,calle,altura,dep")] UserData userData)
        {
            if (ModelState.IsValid)
            {
                db.UserData.Add(userData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", userData.Id_Usuario);
            return View(userData);
        }

        // GET: UsersData/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserData userData = db.UserData.Find(id);
            if (userData == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", userData.Id_Usuario);
            return View(userData);
        }

        // POST: UsersData/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Usuario,nombre,apellido,pais,doc_tipo,num_doc,f_nac,calle,altura,dep")] UserData userData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Id", userData.Id_Usuario);
            return View(userData);
        }

        // GET: UsersData/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserData userData = db.UserData.Find(id);
            if (userData == null)
            {
                return HttpNotFound();
            }
            return View(userData);
        }

        // POST: UsersData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UserData userData = db.UserData.Find(id);
            db.UserData.Remove(userData);
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
