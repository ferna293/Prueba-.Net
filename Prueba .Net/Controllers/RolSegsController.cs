using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prueba.Net.Models;

namespace Prueba.Net.Controllers
{
    public class RolSegsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: RolSegs
        public ActionResult Index()
        {
            return View(db.RolSegs.ToList());
        }

        // GET: RolSegs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolSeg rolSeg = db.RolSegs.Find(id);
            if (rolSeg == null)
            {
                return HttpNotFound();
            }
            return View(rolSeg);
        }

        // GET: RolSegs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RolSegs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_rol,nombre_rol,descripcion,estado")] RolSeg rolSeg)
        {
            if (ModelState.IsValid)
            {
                db.RolSegs.Add(rolSeg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rolSeg);
        }

        // GET: RolSegs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolSeg rolSeg = db.RolSegs.Find(id);
            if (rolSeg == null)
            {
                return HttpNotFound();
            }
            return View(rolSeg);
        }

        // POST: RolSegs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_rol,nombre_rol,descripcion,estado")] RolSeg rolSeg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rolSeg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rolSeg);
        }

        // GET: RolSegs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolSeg rolSeg = db.RolSegs.Find(id);
            if (rolSeg == null)
            {
                return HttpNotFound();
            }
            return View(rolSeg);
        }

        // POST: RolSegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RolSeg rolSeg = db.RolSegs.Find(id);
            db.RolSegs.Remove(rolSeg);
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
