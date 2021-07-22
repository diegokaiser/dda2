using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.ServicioPost;
using WEB_Chambix.ServicioUsuario;
using WEB_Chambix.ServicioTestimonio;
using WEB_Chambix.ServicioServicio;
namespace WEB_Chambix.Controllers
{
    public class AccountController : Controller
    {
        ServicioPostClient post = new ServicioPostClient();
        ServicioUsuarioClient usuario = new ServicioUsuarioClient();
        ServicioServicioClient servicio = new ServicioServicioClient();
        ServicioTestimonioClient testimonio = new ServicioTestimonioClient();
        // GET: Account
        public ActionResult Index()
        {
            //Para iterar los post por usuario
            ViewBag.ListarPostsPorId = post.GetAllPostsPorIdUsuario(Convert.ToInt16(Session["Usuarioid"]));          
            return View();
        }

        public ActionResult DatosPersonales()
        {



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
    }
}