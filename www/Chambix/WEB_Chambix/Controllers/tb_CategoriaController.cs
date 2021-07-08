using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.Models;

namespace WEB_Chambix.Controllers
{
    public class tb_CategoriaController : Controller
    {
        private SistemaServiciosEntities2 db = new SistemaServiciosEntities2();


        // GET: tb_Categoria
        public ActionResult Index()
        {
            return View(db.tb_Categoria.ToList());
        }

        // GET: tb_Categoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // GET: tb_Categoria/Create
        public ActionResult Create()
        {

            ViewBag.Cod_Agente = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario");
            return View();
        }

        // POST: tb_Categoria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCategoria,nombreCategoria,create_at,create_by,update_at,update_by")] tb_Categoria tb_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.tb_Categoria.Add(tb_Categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario");

            return View(tb_Categoria);
        }

        // GET: tb_Categoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // POST: tb_Categoria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCategoria,nombreCategoria,create_at,create_by,update_at,update_by")] tb_Categoria tb_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Categoria);
        }

        // GET: tb_Categoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // POST: tb_Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            db.tb_Categoria.Remove(tb_Categoria);
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
