﻿using System;
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
    public class tb_UsuarioController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();

        // GET: tb_Usuario
        public ActionResult Index()
        {
            var tb_Usuario = db.tb_Usuario.Include(t => t.tb_Distrito).Include(t => t.tb_TipoCuenta);
            return View(tb_Usuario.ToList());
        }

        // GET: tb_Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Usuario tb_Usuario = db.tb_Usuario.Find(id);
            if (tb_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tb_Usuario);
        }

        // GET: tb_Usuario/Create
        public ActionResult Create()
        {
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito");
            ViewBag.idTipoCuenta = new SelectList(db.tb_TipoCuenta, "idTipoCuenta", "nombre");
            return View();
        }

        // POST: tb_Usuario/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idUsuario,tipoUsuario,estadoUsuario,nombreUsuario,apellidoUsuario,contrasenaUsuario,idDistrito,emailUsuario,cellUsuario,rankUsuario,wspUsuario,ocupacionUsuario,idTipoCuenta,tiempoCuenta,create_at,create_by,update_at,update_by")] tb_Usuario tb_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.tb_Usuario.Add(tb_Usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Usuario.idDistrito);
            ViewBag.idTipoCuenta = new SelectList(db.tb_TipoCuenta, "idTipoCuenta", "nombre", tb_Usuario.idTipoCuenta);
            return View(tb_Usuario);
        }

        // GET: tb_Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Usuario tb_Usuario = db.tb_Usuario.Find(id);
            if (tb_Usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Usuario.idDistrito);
            ViewBag.idTipoCuenta = new SelectList(db.tb_TipoCuenta, "idTipoCuenta", "nombre", tb_Usuario.idTipoCuenta);
            return View(tb_Usuario);
        }

        // POST: tb_Usuario/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idUsuario,tipoUsuario,estadoUsuario,nombreUsuario,apellidoUsuario,contrasenaUsuario,idDistrito,emailUsuario,cellUsuario,rankUsuario,wspUsuario,ocupacionUsuario,idTipoCuenta,tiempoCuenta,create_at,create_by,update_at,update_by")] tb_Usuario tb_Usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito", tb_Usuario.idDistrito);
            ViewBag.idTipoCuenta = new SelectList(db.tb_TipoCuenta, "idTipoCuenta", "nombre", tb_Usuario.idTipoCuenta);
            return View(tb_Usuario);
        }

        // GET: tb_Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Usuario tb_Usuario = db.tb_Usuario.Find(id);
            if (tb_Usuario == null)
            {
                return HttpNotFound();
            }
            return View(tb_Usuario);
        }

        // POST: tb_Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Usuario tb_Usuario = db.tb_Usuario.Find(id);
            db.tb_Usuario.Remove(tb_Usuario);
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
