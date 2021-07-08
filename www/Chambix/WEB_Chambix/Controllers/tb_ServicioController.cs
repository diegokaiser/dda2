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
    public class tb_ServicioController : Controller
    {
        private SistemaServiciosEntities2 db = new SistemaServiciosEntities2();

        // GET: tb_Servicio
        public ActionResult Index()
        {
            var tb_Servicio = db.tb_Servicio.Include(t => t.tb_Post).Include(t => t.tb_Usuario);
            return View(tb_Servicio.ToList());
        }

        // GET: tb_Servicio/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Servicio tb_Servicio = db.tb_Servicio.Find(id);
            if (tb_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(tb_Servicio);
        }

        // GET: tb_Servicio/Create
        public ActionResult Create()
        {
            ViewBag.idPost = new SelectList(db.tb_Post, "idPost", "tituloPost");
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario");
            return View();
        }

        // POST: tb_Servicio/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idServicio,idPost,idUsuario,estadoServicio,create_at,create_by,update_at,update_by")] tb_Servicio tb_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.tb_Servicio.Add(tb_Servicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPost = new SelectList(db.tb_Post, "idPost", "tituloPost", tb_Servicio.idPost);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Servicio.idUsuario);
            return View(tb_Servicio);
        }

        // GET: tb_Servicio/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Servicio tb_Servicio = db.tb_Servicio.Find(id);
            if (tb_Servicio == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPost = new SelectList(db.tb_Post, "idPost", "tituloPost", tb_Servicio.idPost);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Servicio.idUsuario);
            return View(tb_Servicio);
        }

        // POST: tb_Servicio/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idServicio,idPost,idUsuario,estadoServicio,create_at,create_by,update_at,update_by")] tb_Servicio tb_Servicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Servicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPost = new SelectList(db.tb_Post, "idPost", "tituloPost", tb_Servicio.idPost);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Servicio.idUsuario);
            return View(tb_Servicio);
        }

        // GET: tb_Servicio/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Servicio tb_Servicio = db.tb_Servicio.Find(id);
            if (tb_Servicio == null)
            {
                return HttpNotFound();
            }
            return View(tb_Servicio);
        }

        // POST: tb_Servicio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Servicio tb_Servicio = db.tb_Servicio.Find(id);
            db.tb_Servicio.Remove(tb_Servicio);
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
