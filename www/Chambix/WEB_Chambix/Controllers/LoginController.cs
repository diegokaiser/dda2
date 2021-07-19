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
    public class LoginController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "idUsuario,tipoUsuario,estadoUsuario,nombreUsuario,apellidoUsuario,contrasenaUsuario,idDistrito,emailUsuario,cellUsuario,rankUsuario,wspUsuario,ocupacionUsuario,idTipoCuenta,tiempoCuenta,create_at,create_by,update_at,update_by")] tb_Usuario tb_Usuario)
        {
            if (ModelState.IsValid) 
            {
                db.tb_Usuario.Add(tb_Usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDistrito = new SelectList(db.tb_Distrito, "idDistrito", "nombreDistrito");
            ViewBag.idTipoCuenta = new SelectList(db.tb_TipoCuenta, "idTipoCuenta", "nombre");
            return View();
        }

        public ActionResult Enter(string emailUsuario, string contrasenaUsuario)
        {
            try
            {
                {
                    var lst = from d in db.tb_Usuario
                              where d.emailUsuario == emailUsuario 
                              && d.contrasenaUsuario == contrasenaUsuario 
                              && d.estadoUsuario == true
                              select d;
                    if(lst.Count()>0)
                    {
                        tb_Usuario oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario inválido");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content(":( no hay pan!" + ex.Message);
            }

        }

        public ActionResult Error()
        {
            return View();
        }
    }
}