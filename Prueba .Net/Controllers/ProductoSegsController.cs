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
    public class ProductoSegsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ProductoSegs
        public ActionResult Index()
        {
            var productoSegs = db.ProductoSegs.Include(p => p.compañia).Include(p => p.rolSeg);
            return View(productoSegs.ToList());
        }

        // GET: ProductoSegs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoSeg productoSeg = db.ProductoSegs.Find(id);
            if (productoSeg == null)
            {
                return HttpNotFound();
            }
            return View(productoSeg);
        }

        // GET: ProductoSegs/Create
        public ActionResult Create()
        {
            ViewBag.id_compañia = new SelectList(db.Compañias, "id_compañia", "nombre_compañia");
            ViewBag.id_rol = new SelectList(db.RolSegs, "id_rol", "nombre_rol");
            return View();
        }

        // POST: ProductoSegs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_producto,nombre_producto,descripcion,estado,id_compañia,id_rol")] ProductoSeg productoSeg)
        {
            if (ModelState.IsValid)
            {
                db.ProductoSegs.Add(productoSeg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_compañia = new SelectList(db.Compañias, "id_compañia", "nombre_compañia", productoSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSegs, "id_rol", "nombre_rol", productoSeg.id_rol);
            return View(productoSeg);
        }

        // GET: ProductoSegs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoSeg productoSeg = db.ProductoSegs.Find(id);
            if (productoSeg == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_compañia = new SelectList(db.Compañias, "id_compañia", "nombre_compañia", productoSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSegs, "id_rol", "nombre_rol", productoSeg.id_rol);
            return View(productoSeg);
        }

        // POST: ProductoSegs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_producto,nombre_producto,descripcion,estado,id_compañia,id_rol")] ProductoSeg productoSeg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productoSeg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_compañia = new SelectList(db.Compañias, "id_compañia", "nombre_compañia", productoSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSegs, "id_rol", "nombre_rol", productoSeg.id_rol);
            return View(productoSeg);
        }

        // GET: ProductoSegs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductoSeg productoSeg = db.ProductoSegs.Find(id);
            if (productoSeg == null)
            {
                return HttpNotFound();
            }
            return View(productoSeg);
        }

        // POST: ProductoSegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductoSeg productoSeg = db.ProductoSegs.Find(id);
            db.ProductoSegs.Remove(productoSeg);
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
