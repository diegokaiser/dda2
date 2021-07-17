using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPost" en el código y en el archivo de configuración a la vez.
    public class ServicioPost : IServicioPost
    {
        public Boolean InsertPost(PostBE objPostBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Post objPost = new tb_Post();
                objPost.idUsuario       = objPostBE.idUsuario;
                objPost.idSubcategoria  = objPostBE.idSubcategoria;
                objPost.idDistrito      = Convert.ToByte(objPostBE.idDistrito);
                objPost.tituloPost      = objPostBE.tituloPost;
                objPost.descripcionPost = objPostBE.descripcionPost;
                objPost.precioPost      = Convert.ToDecimal(objPostBE.precioPost);
                objPost.imagenPost      = objPostBE.imagenPost;
                Chambix.tb_Post.Add(objPost);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdatePost(PostBE objPostBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Post objPost = (from objPst in Chambix.tb_Post
                                   where objPst.idPost == objPostBE.idPost
                                   select objPst).FirstOrDefault();

                objPost.idPost          = objPostBE.idPost;
                objPost.idUsuario       = objPost.idUsuario;
                objPost.idSubcategoria  = objPostBE.idSubcategoria;
                objPost.idDistrito      = Convert.ToByte(objPostBE.idDistrito);
                objPost.tituloPost      = objPostBE.tituloPost;
                objPost.descripcionPost = objPostBE.descripcionPost;
                objPost.precioPost      = Convert.ToDecimal(objPostBE.precioPost);
                objPost.imagenPost      = objPostBE.imagenPost;
                objPost.valoracionPost  = objPostBE.valoracionPost;
                objPost.estadoPost      = Convert.ToBoolean(objPostBE.estadoPost);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean LogicDeletePost(PostBE objPostBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Post objPost = (from objPst in Chambix.tb_Post
                                   where objPst.idPost == objPostBE.idPost
                                   select objPst).FirstOrDefault();
                objPost.estadoPost = false;
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public PostBE GetPost(Int16 idPost)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Post objPost = (from objPst in Chambix.tb_Post
                                   where objPst.idPost == idPost
                                   && objPst.estadoPost == true
                                   select objPst).FirstOrDefault();
                PostBE objPostBE          = new PostBE();
                objPostBE.idPost          = Convert.ToInt16(objPost.idPost);
                objPostBE.idUsuario       = Convert.ToInt16(objPost.idUsuario);
                objPostBE.idSubcategoria  = Convert.ToInt16(objPost.idSubcategoria);
                objPostBE.idDistrito      = Convert.ToInt16(objPost.idDistrito);
                objPostBE.tituloPost      = objPost.tituloPost;
                objPostBE.descripcionPost = objPost.descripcionPost;
                objPostBE.imagenPost      = objPost.imagenPost;
                objPostBE.precioPost      = Convert.ToDecimal(objPost.precioPost);
                objPostBE.valoracionPost  = Convert.ToInt16(objPost.valoracionPost);
                objPostBE.estadoPost      = Convert.ToInt16(objPost.estadoPost);
                objPostBE.create_at       = (DateTime)objPost.create_at;
                return objPostBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PostBE> GetAllPosts()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<PostBE> objPostLists = new List<PostBE>();
                var query = (from objPst in Chambix.tb_Post
                             where objPst.estadoPost == true
                             select objPst);
                foreach(var objPost in query)
                {
                    PostBE objPostBE = new PostBE();
                    objPostBE.idPost = Convert.ToInt16(objPost.idPost);
                    objPostBE.idUsuario = Convert.ToInt16(objPost.idUsuario);
                    objPostBE.idSubcategoria = Convert.ToInt16(objPost.idSubcategoria);
                    objPostBE.idDistrito = Convert.ToInt16(objPost.idDistrito);
                    objPostBE.tituloPost = objPost.tituloPost;
                    objPostBE.descripcionPost = objPost.descripcionPost;
                    objPostBE.imagenPost = objPost.imagenPost;
                    objPostBE.precioPost = Convert.ToDecimal(objPost.precioPost);
                    objPostBE.valoracionPost = Convert.ToInt16(objPost.valoracionPost);
                    objPostBE.estadoPost = Convert.ToInt16(objPost.estadoPost);
                    objPostBE.create_at = (DateTime)objPost.create_at;
                    objPostBE.NombreCategoria = (objPost.tb_SubCategoria.tb_Categoria.nombreCategoria);
                    objPostBE.NombreUsuario = (objPost.tb_Usuario.nombreUsuario);
                    objPostLists.Add(objPostBE);
                }
                return objPostLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<PostBE> GetAllPostsPorCategoria(Int16 idCategoria)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<PostBE> objPostLists = new List<PostBE>();
                //var query = (from objPst in Chambix.tb_Post
                //             where objPst.estadoPost == true
                //             && objPst.idSubcategoria == idSubCategoria
                //             select objPst);
                var query = (from objPst in Chambix.tb_Post
                             where objPst.estadoPost == true
                             && objPst.tb_SubCategoria.tb_Categoria.idCategoria == idCategoria
                             select objPst);
                foreach (var objPost in query)
                {
                    PostBE objPostBE = new PostBE();
                    objPostBE.idPost = Convert.ToInt16(objPost.idPost);
                    objPostBE.idUsuario = Convert.ToInt16(objPost.idUsuario);
                    objPostBE.idSubcategoria = Convert.ToInt16(objPost.idSubcategoria);
                    objPostBE.idDistrito = Convert.ToInt16(objPost.idDistrito);
                    objPostBE.tituloPost = objPost.tituloPost;
                    objPostBE.descripcionPost = objPost.descripcionPost;
                    objPostBE.imagenPost = objPost.imagenPost;
                    objPostBE.precioPost = Convert.ToDecimal(objPost.precioPost);
                    objPostBE.valoracionPost = Convert.ToInt16(objPost.valoracionPost);
                    objPostBE.estadoPost = Convert.ToInt16(objPost.estadoPost);
                    objPostBE.create_at = (DateTime)objPost.create_at;
                    objPostBE.NombreCategoria = (objPost.tb_SubCategoria.tb_Categoria.nombreCategoria);
                    objPostBE.NombreUsuario = (objPost.tb_Usuario.nombreUsuario);
                    objPostLists.Add(objPostBE);
                }
                return objPostLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 GetContarPostPorCategoria(Int16 idPost)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                Int16 cantPostPorCategoria = Convert.ToInt16(
                    (from objPst in Chambix.tb_Post
                     where objPst.idPost == idPost
                     && objPst.estadoPost == true
                     select objPst).Count()
                    );
                return cantPostPorCategoria;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
