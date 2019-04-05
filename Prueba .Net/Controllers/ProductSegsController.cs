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
    public class ProductSegsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: ProductSegs
        public ActionResult Index()
        {
            var product = db.Product.Include(p => p.compañia).Include(p => p.rolSeg);
            return View(product.ToList());
        }

        // GET: ProductSegs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSeg productSeg = db.Product.Find(id);
            if (productSeg == null)
            {
                return HttpNotFound();
            }
            return View(productSeg);
        }

        // GET: ProductSegs/Create
        public ActionResult Create()
        {
            ViewBag.id_compañia = new SelectList(db.Company, "id_compañia", "nombre_compañia");
            ViewBag.id_rol = new SelectList(db.RolSeg, "id_rol", "nombre_rol");
            return View();
        }

        // POST: ProductSegs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_producto,nombre_producto,descripcion,estado,id_compañia,id_rol")] ProductSeg productSeg)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(productSeg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_compañia = new SelectList(db.Company, "id_compañia", "nombre_compañia", productSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSeg, "id_rol", "nombre_rol", productSeg.id_rol);
            return View(productSeg);
        }

        // GET: ProductSegs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSeg productSeg = db.Product.Find(id);
            if (productSeg == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_compañia = new SelectList(db.Company, "id_compañia", "nombre_compañia", productSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSeg, "id_rol", "nombre_rol", productSeg.id_rol);
            return View(productSeg);
        }

        // POST: ProductSegs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_producto,nombre_producto,descripcion,estado,id_compañia,id_rol")] ProductSeg productSeg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productSeg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_compañia = new SelectList(db.Company, "id_compañia", "nombre_compañia", productSeg.id_compañia);
            ViewBag.id_rol = new SelectList(db.RolSeg, "id_rol", "nombre_rol", productSeg.id_rol);
            return View(productSeg);
        }

        // GET: ProductSegs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSeg productSeg = db.Product.Find(id);
            if (productSeg == null)
            {
                return HttpNotFound();
            }
            return View(productSeg);
        }

        // POST: ProductSegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductSeg productSeg = db.Product.Find(id);
            db.Product.Remove(productSeg);
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
