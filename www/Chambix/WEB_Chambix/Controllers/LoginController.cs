using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.Models;
using WEB_Chambix.ServicioDistrito;
using WEB_Chambix.ServicioUsuario;


namespace WEB_Chambix.Controllers
{
    public class LoginController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();
        ServicioDistritoClient distrito = new ServicioDistritoClient();
        ServicioUsuarioClient usuario = new ServicioUsuarioClient();


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
                        Session["Usuarioid"] = oUser.idUsuario;
                        Session["SesionNombre"] = oUser.nombreUsuario;
                        Session["IdDistrito"] = oUser.idDistrito;
                        Session["NombreDistrito"] = oUser.tb_Distrito.nombreDistrito;
                        Session["Rank"] = oUser.rankUsuario; ;




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

        public ActionResult Register()
        {
            ViewData["cboDistritos"] = LlenarDistritos(); 

            return View();
        }

        public ActionResult LlenarDistritos()
        {
            List<SelectListItem> items = new SelectList(distrito.GetAllDistritos(),
                "idDistrito", "nombreDistrito").ToList();
            items.Insert(0, (new SelectListItem { Text = "Distrito", Value = "0" }));
            ViewBag.ListarDistritos = items;
            return View();
        }

        public ActionResult EnviarRegistro(FormCollection fc) {
            //confirmarcontasena

            Int16 dis = Convert.ToInt16(fc["cboDistritos"]);

            String nombre = Request.Form["nombre"].ToString();
            String apellido = Request.Form["apellido"].ToString();
            String contasena = Request.Form["contrasena"].ToString();
            String correo = Request.Form["correo"].ToString();
            Int16 distrito = dis;
            String celular = Request.Form["celular"].ToString();
            String ocupacion = Request.Form["ocupacion"].ToString();
            String wsp = Request.Form["wsp"].ToString();
            usuario.InsertUser(nombre, apellido, contasena, distrito,correo , celular, wsp, ocupacion);

            return RedirectToAction("Index");
        }
        public ActionResult CerrarSesion( )
        {

            //Session.Abandon();

            HttpContext.Session.Abandon();
            HttpContext.Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));

            return RedirectToAction("Index","Login");
        }

    }
}

