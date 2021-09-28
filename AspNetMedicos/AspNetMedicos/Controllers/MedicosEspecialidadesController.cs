using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AspNetMedicos.DAO;
using AspNetMedicos.Models;

namespace AspNetMedicos.Controllers
{
    public class MedicosEspecialidadesController : Controller
    {
        private EFContext db = new EFContext();

        // GET: MedicosEspecialidades
        public ActionResult Index()
        {
            var medicosEspecialidades = db.MedicosEspecialidades.Include(m => m.Especialidade).Include(m => m.Medico);
            return View(medicosEspecialidades.ToList());
        }

        // GET: MedicosEspecialidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicosEspecialidades medicosEspecialidades = db.MedicosEspecialidades.Find(id);
            if (medicosEspecialidades == null)
            {
                return HttpNotFound();
            }
            return View(medicosEspecialidades);
        }

        // GET: MedicosEspecialidades/Create
        public ActionResult Create()
        {
            ViewBag.EspecialidadesId = new SelectList(db.Especialidades, "EspecialidadesId", "nome");
            ViewBag.MedicosId = new SelectList(db.Medicos, "MedicosId", "crm");
            return View();
        }

        // POST: MedicosEspecialidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedicosEspecialidadesId,MedicosId,EspecialidadesId")] MedicosEspecialidades medicosEspecialidades)
        {
            if (ModelState.IsValid)
            {
                db.MedicosEspecialidades.Add(medicosEspecialidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EspecialidadesId = new SelectList(db.Especialidades, "EspecialidadesId", "nome", medicosEspecialidades.EspecialidadesId);
            ViewBag.MedicosId = new SelectList(db.Medicos, "MedicosId", "crm", medicosEspecialidades.MedicosId);
            return View(medicosEspecialidades);
        }

        // GET: MedicosEspecialidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicosEspecialidades medicosEspecialidades = db.MedicosEspecialidades.Find(id);
            if (medicosEspecialidades == null)
            {
                return HttpNotFound();
            }
            ViewBag.EspecialidadesId = new SelectList(db.Especialidades, "EspecialidadesId", "nome", medicosEspecialidades.EspecialidadesId);
            ViewBag.MedicosId = new SelectList(db.Medicos, "MedicosId", "crm", medicosEspecialidades.MedicosId);
            return View(medicosEspecialidades);
        }

        // POST: MedicosEspecialidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedicosEspecialidadesId,MedicosId,EspecialidadesId")] MedicosEspecialidades medicosEspecialidades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medicosEspecialidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EspecialidadesId = new SelectList(db.Especialidades, "EspecialidadesId", "nome", medicosEspecialidades.EspecialidadesId);
            ViewBag.MedicosId = new SelectList(db.Medicos, "MedicosId", "crm", medicosEspecialidades.MedicosId);
            return View(medicosEspecialidades);
        }

        // GET: MedicosEspecialidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedicosEspecialidades medicosEspecialidades = db.MedicosEspecialidades.Find(id);
            if (medicosEspecialidades == null)
            {
                return HttpNotFound();
            }
            return View(medicosEspecialidades);
        }

        // POST: MedicosEspecialidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedicosEspecialidades medicosEspecialidades = db.MedicosEspecialidades.Find(id);
            db.MedicosEspecialidades.Remove(medicosEspecialidades);
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
