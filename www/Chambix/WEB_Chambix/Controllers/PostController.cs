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
    public class PostController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();

        // GET: Post
        public ActionResult Index()
        {
            var tb_Post = db.tb_Post.Include(t => t.tb_Distrito).Include(t => t.tb_SubCategoria).Include(t => t.tb_Usuario);
            return View(tb_Post.ToList());
        }

        public ActionResult Interna()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }
    }
}