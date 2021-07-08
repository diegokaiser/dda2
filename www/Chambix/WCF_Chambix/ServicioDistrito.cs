using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDistrito" en el código y en el archivo de configuración a la vez.
    public class ServicioDistrito : IServicioDistrito
    {

        public List<DistritoBE> GetAllDistritos()
        {
            SistemaServiciosEntities MisVentas = new SistemaServiciosEntities();

            try
            {
                List<DistritoBE> objListaDistritos = new List<DistritoBE>();
                var query = (from objDis in MisVentas.tb_Distrito
                             select objDis);
                foreach (var objVendedor in query)
                {
                    DistritoBE objDistritosBE = new DistritoBE();
                    objDistritosBE.idDistrito = objVendedor.idDistrito;
                    objDistritosBE.nombreDistrito = objVendedor.nombreDistrito;
                    objListaDistritos.Add(objDistritosBE);

                }
                return objListaDistritos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
