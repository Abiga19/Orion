using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace calypso_app.Models
{
    public class tipo_memoriaController : Controller
    {
        private Entities db = new Entities();

        // GET: tipo_memoria
        public ActionResult Index()
        {
            return View(db.tipo_memoria.ToList());
        }

        // GET: tipo_memoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_memoria tipo_memoria = db.tipo_memoria.Find(id);
            if (tipo_memoria == null)
            {
                return HttpNotFound();
            }
            return View(tipo_memoria);
        }

        // GET: tipo_memoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tipo_memoria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_tipomemoria,descripcion_tipomemoria,estatus_tipomemoria")] tipo_memoria tipo_memoria)
        {
            if (ModelState.IsValid)
            {
                db.tipo_memoria.Add(tipo_memoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_memoria);
        }

        // GET: tipo_memoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_memoria tipo_memoria = db.tipo_memoria.Find(id);
            if (tipo_memoria == null)
            {
                return HttpNotFound();
            }
            return View(tipo_memoria);
        }

        // POST: tipo_memoria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_tipomemoria,descripcion_tipomemoria,estatus_tipomemoria")] tipo_memoria tipo_memoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_memoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_memoria);
        }

        // GET: tipo_memoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tipo_memoria tipo_memoria = db.tipo_memoria.Find(id);
            if (tipo_memoria == null)
            {
                return HttpNotFound();
            }
            return View(tipo_memoria);
        }

        // POST: tipo_memoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tipo_memoria tipo_memoria = db.tipo_memoria.Find(id);
            db.tipo_memoria.Remove(tipo_memoria);
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
