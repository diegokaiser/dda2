using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;


namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSubCategoria" en el código y en el archivo de configuración a la vez.
    public class ServicioSubCategoria : IServicioSubCategoria
    {
        public void DoWork()
        {
        }

        public List<SubCategoriaBE> GetAllSubCategoria()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<SubCategoriaBE> objLisSubCategoria = new List<SubCategoriaBE>();

                var query = (from objSubCat in Chambix.tb_SubCategoria
                             select objSubCat);
                foreach (var objSubCategoria in query)
                {
                    SubCategoriaBE objSubCategoriaBE = new SubCategoriaBE();

                    objSubCategoriaBE.idSubCategoria = Convert.ToInt16(objSubCategoria.idSubCategoria);
                    objSubCategoriaBE.idCategoria = Convert.ToInt16(objSubCategoria.idCategoria);
                    objSubCategoriaBE.nombreSubCategoria = Convert.ToString(objSubCategoria.nombreSubCategoria);
                    objSubCategoriaBE.create_at = Convert.ToDateTime(objSubCategoria.create_at);
                    objSubCategoriaBE.create_by = Convert.ToString(objSubCategoria.create_by);
                    objSubCategoriaBE.update_at = Convert.ToDateTime(objSubCategoria.update_at);
                    objSubCategoriaBE.update_by = Convert.ToString(objSubCategoria.update_by);

                    objLisSubCategoria.Add(objSubCategoriaBE);


                }
                return objLisSubCategoria;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
