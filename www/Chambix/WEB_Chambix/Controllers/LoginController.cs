using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.Models;

namespace WEB_Chambix.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Enter(string emailUsuario, string contrasenaUsuario)
        {
            try
            {
                using(SistemaServiciosEntities db = new SistemaServiciosEntities())
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