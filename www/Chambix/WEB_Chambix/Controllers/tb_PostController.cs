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
    public class tb_PostController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();

        // GET: tb_Post
        public ActionResult Index()
        {
            var tb_Post = db.tb_Post.Include(t => t.tb_Distrito).Include(t => t.tb_SubCategoria).Include(t => t.tb_Usuario);
            return View(tb_Post.ToList());
        }

        // GET: tb_Post/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            return View(tb_Post);
        }

        // GET: tb_Post/Create
        public ActionResult Create()
        {
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito");
            ViewBag.idSubcategoria = new SelectList(db.tb_SubCategoria, "idSubCategoria", "nombreSubCategoria");
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario");
            return View();
        }

        // POST: tb_Post/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPost,idUsuario,idSubcategoria,idDistrito,tituloPost,descripcionPost,precioPost,imagenPost,valoracionPost,estadoPost,create_at,create_by,update_at,update_by")] tb_Post tb_Post)
        {
            if (ModelState.IsValid)
            {
                db.tb_Post.Add(tb_Post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Post.idDistrito);
            ViewBag.idSubcategoria = new SelectList(db.tb_SubCategoria, "idSubCategoria", "nombreSubCategoria", tb_Post.idSubcategoria);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Post.idUsuario);
            return View(tb_Post);
        }

        // GET: tb_Post/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Post.idDistrito);
            ViewBag.idSubcategoria = new SelectList(db.tb_SubCategoria, "idSubCategoria", "nombreSubCategoria", tb_Post.idSubcategoria);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Post.idUsuario);
            return View(tb_Post);
        }

        // POST: tb_Post/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPost,idUsuario,idSubcategoria,idDistrito,tituloPost,descripcionPost,precioPost,imagenPost,valoracionPost,estadoPost,create_at,create_by,update_at,update_by")] tb_Post tb_Post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Post.idDistrito);
            ViewBag.idSubcategoria = new SelectList(db.tb_SubCategoria, "idSubCategoria", "nombreSubCategoria", tb_Post.idSubcategoria);
            ViewBag.idUsuario = new SelectList(db.tb_Usuario, "idUsuario", "nombreUsuario", tb_Post.idUsuario);
            return View(tb_Post);
        }

        // GET: tb_Post/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Post tb_Post = db.tb_Post.Find(id);
            if (tb_Post == null)
            {
                return HttpNotFound();
            }
            return View(tb_Post);
        }

        // POST: tb_Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Post tb_Post = db.tb_Post.Find(id);
            db.tb_Post.Remove(tb_Post);
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
