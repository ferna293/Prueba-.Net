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
    public class CompañiaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: Compañia
        public ActionResult Index()
        {
            return View(db.compañia.ToList());
        }

        // GET: Compañia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compañia compañia = db.compañia.Find(id);
            if (compañia == null)
            {
                return HttpNotFound();
            }
            return View(compañia);
        }

        // GET: Compañia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compañia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_compañia,nombre_compañia,descripcion,estado")] Compañia compañia)
        {
            if (ModelState.IsValid)
            {
                db.compañia.Add(compañia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compañia);
        }

        // GET: Compañia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compañia compañia = db.compañia.Find(id);
            if (compañia == null)
            {
                return HttpNotFound();
            }
            return View(compañia);
        }

        // POST: Compañia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_compañia,nombre_compañia,descripcion,estado")] Compañia compañia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compañia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compañia);
        }

        // GET: Compañia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Compañia compañia = db.compañia.Find(id);
            if (compañia == null)
            {
                return HttpNotFound();
            }
            return View(compañia);
        }

        // POST: Compañia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Compañia compañia = db.compañia.Find(id);
            db.compañia.Remove(compañia);
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
