using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using System.Data.Entity;
using System.Net;

namespace WebApplication3.Controllers
{
    public class MedicosController : Controller
    {
        private EntidadesCadeMedico db = new EntidadesCadeMedico();
        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include(m => m.Cidades).Include(m => m.Especialidades).ToList();
            return View(medicos);

        }
        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade ", "Especialidade");

            return View ();
        }
        [HttpPost]
        public ActionResult Adicionar(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade ", "Especialidade", medico.IDEspecialidade);


            return View(medico);
        }

        public ActionResult Editar(long id)
        {
            if(id ==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicos medico = db.Medicos.Find(id);
            if(medico == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade ", "Especialidade", medico.IDEspecialidade);
            return View(medico);
        }

        [HttpPost]
        public ActionResult Editar(Medicos medico)
        {
            if(ModelState.IsValid)
            {
                db.Entry(medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Cidade", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade ", "Especialidade", medico.IDEspecialidade);

            return View(medico);

        }

        //public string Excluir(long id)
        //{
        //    try
        //    {
        //        Medicos medico = db.Medicos.Find(id);
        //        db.Medicos.Remove(medico);
        //        db.SaveChanges();
        //        return Boolean.TrueString;
        //    }
        //    catch { return Boolean.FalseString; }

        //}

        public ActionResult Excluir(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medicos medico = db.Medicos.Find(id);
            if (medico == null)
            {
                return HttpNotFound();
            }
            return View(medico);

        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(long id)
        {
            Medicos medico = db.Medicos.Find(id);
            db.Medicos.Remove(medico);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}