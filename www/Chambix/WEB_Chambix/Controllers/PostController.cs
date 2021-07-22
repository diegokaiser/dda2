﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEB_Chambix.Models;
using WEB_Chambix.ServicioPost;
using WEB_Chambix.ServicioCategoria;
using WEB_Chambix.ServicioTestimonio;
using WEB_Chambix.ServicioServicio;
using WEB_Chambix.ServicioSubCategoria;
using WEB_Chambix.ServicioDistrito;





using System.Globalization;


namespace WEB_Chambix.Controllers
{
    public class PostController : Controller
    {
        ServicioPostClient post = new ServicioPostClient();
        ServicioCategoriaClient categoria = new ServicioCategoriaClient();
        ServicioTestimonioClient testimonio = new ServicioTestimonioClient();
        ServicioServicioClient servicio = new ServicioServicioClient();
        ServicioSubCategoriaClient subCategoria = new ServicioSubCategoriaClient();
        ServicioDistritoClient distrito = new ServicioDistritoClient();


        // GET: Post
        public ActionResult Index(FormCollection fc)
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

            if (condicion.Equals("Por Categoria"))
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
        public ActionResult Interna(String id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.ObjetoPost = post.GetPost(Convert.ToInt16(id));
            ViewBag.ListaComentarios = testimonio.GetAllTestimonioId(Convert.ToInt32(id));
            if (post.GetPost(Convert.ToInt16(id)) == null)
            {
                return HttpNotFound();
            }
            ViewBag.SesionNombre = Session["SesionNombre"];
            return View();
        }
        public ActionResult Crear(FormCollection fc)
        {
            ViewData["cboSubCategoria"] = LlenarSubCategorias();
            ViewData["cboDistrito"] = LlenarDistritos();


            return View();
        }
        public ActionResult LlenarSubCategorias()
        {
            List<SelectListItem> items = new SelectList(subCategoria.GetAllSubCategoria(),
                "idSubcategoria", "nombreSubcategoria").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione Categoria", Value = "0" }));
            ViewBag.ListarSubCategorias = items;
            return View();
        }
        public ActionResult LlenarDistritos()
        {
            List<SelectListItem> items = new SelectList(distrito.GetAllDistritos(),
                "idDistrito", "nombreDistrito").ToList();
            items.Insert(0, (new SelectListItem { Text = "Seleccione distrito", Value = "0" }));
            ViewBag.ListarDistritos = items;
            return View();
        }
        public ActionResult SetComentario()
        {
            Int16 idUsuario = Convert.ToInt16(Session["Usuarioid"]);
            Int16 idPost = Convert.ToInt16(Request.Form["idPost"]);
            String tituloTestimonio = Request.Form["titulo"].ToString();
            String descripcionTestimonio = Request.Form["comentario"].ToString();

            testimonio.InsertTestimonio(idUsuario, idPost, tituloTestimonio, descripcionTestimonio);
            return RedirectToAction("Interna/" + idPost);
        }

        public ActionResult AceptarServicio()
        {
            Int16 idUsuario = Convert.ToInt16(Session["Usuarioid"]);
            Int16 postId = Convert.ToInt16(Request.Form["postId"]);

            if (servicio.VerificarServicioExiste(idUsuario, postId) <= 0)
            {
                servicio.InsertServicio(idUsuario, postId);
            }
            return RedirectToAction("Interna/" + postId);
        }


        public ActionResult Filtros()
        {
            String palabra = Convert.ToString(Request.Form["buscar"]);
            ViewData["cboCategorias"] = LlenarCategorias();
            ViewBag.ListarPosts = post.GetPostLike(palabra);
            return View();
        }
        [ValidateInput(false)]
        public ActionResult CrearPost(FormCollection fc)
        {
            Int16 usuario = Convert.ToInt16(Session["Usuarioid"]);
            String titulo = Convert.ToString(Request.Form["tituloPost"]);
            String descripcion = fc["editor"];
            Int16 distrito = Convert.ToInt16(fc["cboDistrito"]);
            String descripcion2 = Convert.ToString(Request.Form["edi"]);
            var plainText = HtmlUtilities.ConvertToPlainText(string html);
            Int16 subCategoria = Convert.ToInt16(fc["cboSubCategoria"]);

            post.InsertPost(usuario, subCategoria, distrito, titulo, descripcion2);
            return View();
        }
    }
}