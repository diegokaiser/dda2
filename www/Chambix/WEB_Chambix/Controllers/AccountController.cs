using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.ServicioPost;
namespace WEB_Chambix.Controllers
{
    public class AccountController : Controller
    {
        ServicioPostClient post = new ServicioPostClient();
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
    }
}