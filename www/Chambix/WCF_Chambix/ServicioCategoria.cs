using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCategoria" en el código y en el archivo de configuración a la vez.
    public class ServicioCategoria : IServicioCategoria
    {
        public List<CategoriaBE> GetAllCategoria()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<CategoriaBE> objLisCategoria = new List<CategoriaBE>();

                var query = (from objCat in Chambix.tb_Categoria
                             select objCat);
                foreach (var objCategoria in query)
                {
                    CategoriaBE objCategoriaBE = new CategoriaBE();

                    objCategoriaBE.idCategoria = Convert.ToInt16(objCategoria.idCategoria);
                    objCategoriaBE.nombreCategoria = Convert.ToString(objCategoria.nombreCategoria);
                    objCategoriaBE.create_at = Convert.ToDateTime(objCategoria.create_at);
                    objCategoriaBE.create_by = Convert.ToString(objCategoria.create_by);
                    objCategoriaBE.update_at = Convert.ToDateTime(objCategoria.update_at);
                    objCategoriaBE.update_by = Convert.ToString(objCategoria.update_by);

                    objLisCategoria.Add(objCategoriaBE);


                }
                return objLisCategoria;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertCategoria(CategoriaBE objcategoriaBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Categoria objCategoria = new tb_Categoria();
                objCategoria.nombreCategoria = objcategoriaBE.nombreCategoria;
                Chambix.tb_Categoria.Add(objCategoria);

                Chambix.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean UpdateCategoria(CategoriaBE objcategoriaBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Categoria objCategoria = (from objCat in Chambix.tb_Categoria
                                             where objCat.idCategoria == objcategoriaBE.idCategoria
                                             select objCat).FirstOrDefault();
                objCategoria.idCategoria = objcategoriaBE.idCategoria;
                objCategoria.nombreCategoria = objcategoriaBE.nombreCategoria;

                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean DeleteCategoria(Int16 id)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Categoria objCategoria = (from objcat in Chambix.tb_Categoria
                                             where objcat.idCategoria == id
                                             select objcat).FirstOrDefault();

                Chambix.tb_Categoria.Remove(objCategoria);
                Chambix.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
