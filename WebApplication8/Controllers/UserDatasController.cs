using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Datos;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace WebApplication8.Controllers
{
    public class UserDatasController : Controller
    {
        
        private MotoDeliveryEntities db = new MotoDeliveryEntities();

        // GET: UserDatas
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var userData = db.UserData.Include(u => u.AspNetUsers);
            return View(await userData.ToListAsync());
        }

        // GET: UserDatas/Details/5
        public async Task<ActionResult> Details( string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           UserData userData = await db.UserData.FindAsync(id);
           
            if (userData == null)
            {
                return HttpNotFound();
            }
            return View(userData);
        }

        // GET: UserDatas/Create
        public ActionResult Create()
        {
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Email");
            return View();
        }

        // POST: UserDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id_Usuario,nombre,apellido,pais,doc_tipo,num_doc,f_nac,calle,altura,dep,UsuarioNuevo")] UserData userData)
        {
            if (ModelState.IsValid)
            {
                db.UserData.Add(userData);
                await db.SaveChangesAsync();
                return RedirectToAction("Details", "UserDatas");
            }

            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Email", userData.Id_Usuario);
            return View(userData);
        }

        // GET: UserDatas/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserData userData = await db.UserData.FindAsync(id);
            if (userData == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Email", userData.Id_Usuario);
            return View(userData);
        }

        // POST: UserDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id_Usuario,nombre,apellido,pais,doc_tipo,num_doc,f_nac,calle,altura,dep,UsuarioNuevo")] UserData userData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userData).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Usuario = new SelectList(db.AspNetUsers, "Id", "Email", userData.Id_Usuario);
            return View(userData);
        }

        // GET: UserDatas/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserData userData = await db.UserData.FindAsync(id);
            if (userData == null)
            {
                return HttpNotFound();
            }
            return View(userData);
        }

        // POST: UserDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            UserData userData = await db.UserData.FindAsync(id);
            db.UserData.Remove(userData);
            await db.SaveChangesAsync();
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
