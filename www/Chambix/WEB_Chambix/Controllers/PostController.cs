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
        }
    }
}