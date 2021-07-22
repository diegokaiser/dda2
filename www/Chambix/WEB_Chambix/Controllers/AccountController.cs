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
        public ActionResult VerPostulantes()
        {
            ViewBag.ListarPostsPorId = post.GetAllPostsServiciosPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));

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

    }
}