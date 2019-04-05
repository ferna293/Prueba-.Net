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
    public class TypeDocumentsController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TypeDocuments
        public ActionResult Index()
        {
            return View(db.TypeDocument.ToList());
        }

        // GET: TypeDocuments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDocument typeDocument = db.TypeDocument.Find(id);
            if (typeDocument == null)
            {
                return HttpNotFound();
            }
            return View(typeDocument);
        }

        // GET: TypeDocuments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeDocuments/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tipo_document,nombre_document,estado")] TypeDocument typeDocument)
        {
            if (ModelState.IsValid)
            {
                db.TypeDocument.Add(typeDocument);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeDocument);
        }

        // GET: TypeDocuments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDocument typeDocument = db.TypeDocument.Find(id);
            if (typeDocument == null)
            {
                return HttpNotFound();
            }
            return View(typeDocument);
        }

        // POST: TypeDocuments/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tipo_document,nombre_document,estado")] TypeDocument typeDocument)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeDocument).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeDocument);
        }

        // GET: TypeDocuments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDocument typeDocument = db.TypeDocument.Find(id);
            if (typeDocument == null)
            {
                return HttpNotFound();
            }
            return View(typeDocument);
        }

        // POST: TypeDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeDocument typeDocument = db.TypeDocument.Find(id);
            db.TypeDocument.Remove(typeDocument);
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
