using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.ServicioPost;
using WEB_Chambix.ServicioUsuario;
using WEB_Chambix.ServicioTestimonio;
using WEB_Chambix.ServicioServicio;
using WEB_Chambix.ServicioDistrito;

namespace WEB_Chambix.Controllers
{
    public class AccountController : Controller
    {
        ServicioPostClient post = new ServicioPostClient();
        ServicioUsuarioClient usuario = new ServicioUsuarioClient();
        ServicioServicioClient servicio = new ServicioServicioClient();
        ServicioTestimonioClient testimonio = new ServicioTestimonioClient();
        ServicioDistritoClient distrito = new ServicioDistritoClient();
        // GET: Account
        public ActionResult Index()
        {
            //Para iterar los post por usuario
            ViewBag.ListarPostsPorId = post.GetAllPostsPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));          
            return View();
        }

        public ActionResult DatosPersonales()
        {

            ViewBag.UsuarioDatos = usuario.GetUser(Convert.ToInt16(Session["Usuarioid"]));
            ViewData["cboDistrito"] = LlenarDistritos();

            return View();

      
        }
        public ActionResult Estadisticas()
        {
            ViewBag.publicaciones = post.GetContarPost();
            ViewBag.publicacionesUsuario = post.GetContarPostPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));
            ViewBag.usuarios = usuario.GetContarUsuarios();
            ViewBag.Testimonios = testimonio.GetContarTestimonio();
            ViewBag.TestimoniosUsuarios = testimonio.GetContarTestimonioIdUsuario(Convert.ToInt16(Session["Usuarioid"]));
            ViewBag.Servicios = servicio.GetContarServiciosContratados();
            ViewBag.ServiciosUsuarios = servicio.GetContarServiciosContratadosPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));
            
            return View();
        }
        public ActionResult Postulaciones()
        {
            ViewBag.ListarPostsPorId = post.GetAllPostsServiciosPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));

            return View();
        }
        public ActionResult VerPostulantes(String idPost)
        {
           //ViewBag.ListarPostsPorId = post.GetAllPostsServiciosPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));
           ViewBag.Post= post.GetPost(Convert.ToInt16(idPost));
         
            ViewBag.UsuariosP= usuario.GetAllUsersPostulantes(Convert.ToInt16(idPost));
            return View();
        }
        public ActionResult DeshabilitarPost(String id)
        {

            //post.LogicDeletePost(Convert.ToInt16(Request.Form["idPostH"]));
            post.LogicDeletePost(Convert.ToInt16(id));


            return RedirectToAction("Index", "Account");
        }

        public ActionResult UsuariosPostulantes()
        {

            //post.LogicDeletePost(Convert.ToInt16(Request.Form["idPostH"]));
            //post.LogicDeletePost(Convert.ToInt16(id));


            return RedirectToAction("Index", "Account");
        }
        public ActionResult LlenarDistritos()
        {
            List<SelectListItem> items = new SelectList(distrito.GetAllDistritos(),
                "idDistrito", "nombreDistrito", Session["IdDistrito"].ToString()).ToList();         
            items.Insert(0, (new SelectListItem { Text = "Seleccione distrito", Value = "0"}));
            ViewBag.ListarDistritos = items;
            return View();
        }

        public ActionResult UpdateUsuario(FormCollection fc)
        {

            Int16 dis = Convert.ToInt16(fc["cboDistritos"]);
            Int16 idUsuario = Convert.ToInt16(Session["Usuarioid"]);
            String nombre = Request.Form["nombres"].ToString();
            String apellido = Request.Form["apellidos"].ToString();
            String contasena = Request.Form["contrasena"].ToString();
            String correo = Request.Form["correo"].ToString();
            Int16 distrito = dis;
            String celular = Request.Form["celular"].ToString();
            String ocupacion = Request.Form["ocupacion"].ToString();
            String wsp = Request.Form["wsp"].ToString();
            usuario.UpdateUser(idUsuario, nombre, apellido, contasena, distrito, correo, celular, ocupacion, wsp);
            return RedirectToAction("DatosPersonales", "Account");
        }



    }
}