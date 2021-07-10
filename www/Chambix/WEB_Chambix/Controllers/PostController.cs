using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.Models;
using WEB_Chambix.ServicioPostAz;
using WEB_Chambix.ServicioCategoriaAz;


namespace WEB_Chambix.Controllers
{
    public class PostController : Controller
    {
        private SistemaServiciosEntities db = new SistemaServiciosEntities();
        ServicioPostClient post = new ServicioPostClient();
        ServicioCategoriaClient categoria = new ServicioCategoriaClient();

        // GET: Post
        public ActionResult Index()
        {


            //var tb_Post = db.tb_Post.Include(t => t.tb_Distrito).Include(t => t.tb_SubCategoria).Include(t => t.tb_Usuario);
            //ViewData["cboCategorias"] = LlenarCategorias();
            //return View(tb_Post.ToList());
            ViewBag.ListarPosts = post.GetAllPosts();

            //Para el llenado de los combos

            ViewData["cboCategorias"] = LlenarCategorias();
            return View();
        }
        public ActionResult Buscar(FormCollection fc)
        {
            //Se toman los valores de los controles
            String criterioCategoria = fc["cboCategorias"];
            String condicion = fc["condicion"];
            Console.Write(criterioCategoria);
            

            if (condicion.Equals("PorCategoria"))
            {
                ViewBag.ListarPosts = post.GetAllPostsPorCategoria(Int16.Parse(criterioCategoria));
            }
            else
            {
                ViewBag.ListarPosts = post.GetAllPosts();
            }
            ViewData["cboCategorias"] = LlenarCategorias();
            return View("Index");

        }
        public ActionResult LlenarCategorias()
        {
            List<SelectListItem> items = new SelectList(categoria.GetAllCategoria(),
                "idCategoria", "nombreCategoria").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione categoria", Value = "0" }));
            ViewBag.ListarCategorias = items;
            return View();
        }
    }
}
