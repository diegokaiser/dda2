using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity.Core;
using System.Data;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioServicio" en el código y en el archivo de configuración a la vez.
    public class ServicioServicio : IServicioServicio
    {
        public Boolean InsertServicio( Int16 idUsuario,Int16 idPost)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Servicio objServicio = new tb_Servicio();
                
                objServicio.idPost = idPost;
                objServicio.idUsuario= idUsuario;
                Chambix.tb_Servicio.Add(objServicio);
                Chambix.SaveChanges();             
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean UpdateServicio(ServicioBE objServicioBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Servicio objServicio = (from objServ in Chambix.tb_Servicio
                                   where objServ.idServicio == objServicioBE.idServicio
                                   select objServ).FirstOrDefault();

                objServicio.idServicio = objServicio.idServicio;
                objServicio.idPost = objServicio.idPost;
                objServicio.idUsuario = objServicio.idUsuario;
                objServicio.estadoServicio = Convert.ToBoolean(objServicioBE.estadoServicio);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ServicioBE GetServicio(Int16 idServicio)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Servicio objServicio= (from objServ in Chambix.tb_Servicio
                                   where objServ.idServicio == idServicio
                                    select objServ).FirstOrDefault();

                ServicioBE objServicioBE = new ServicioBE();
                
                objServicioBE.idPost = Convert.ToInt16(objServicio.idPost);
                objServicioBE.idUsuario = Convert.ToInt16(objServicio.idUsuario);
                objServicioBE.estadoServicio = Convert.ToByte(objServicio.estadoServicio);
                
                return objServicioBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ServicioBE> GetAllServicio()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<ServicioBE> objServiciostLists = new List<ServicioBE>();

                var query = (from objServ in Chambix.tb_Servicio
                             select objServ);
                foreach (var objServicio in query)
                {
                    ServicioBE objServicioBE = new ServicioBE();

                    objServicioBE.idPost = Convert.ToInt16(objServicio.idPost);
                    objServicioBE.idUsuario = Convert.ToInt16(objServicio.idUsuario);
                    objServicioBE.estadoServicio = Convert.ToByte(objServicio.estadoServicio);
                    //objServicioBE.create_at = objServicio.create_at;
                    //objServicioBE.create_by = objServicio.create_by;
                    //objServicioBE.update_at = objServicio.update_at;
                    //objServicioBE.update_by = objServicio.update_by;
                    objServiciostLists.Add(objServicioBE);
                }
                return objServiciostLists;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int VerificarServicioExiste(Int16 idUsuario, Int16 idPost)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                Int16 serviciosRepetidos = Convert.ToInt16(
                    (from objPst in Chambix.tb_Servicio
                     where objPst.idPost == idPost
                     && objPst.idUsuario == idUsuario
                     select objPst).Count()
                    );
                return serviciosRepetidos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 GetContarServiciosContratados()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                Int16 serviciosRepetidos = Convert.ToInt16(
                    (from cantServi in Chambix.tb_Servicio
                     where cantServi.estadoServicio == true
                     select cantServi).Count()
                    );
                return serviciosRepetidos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 GetContarServiciosContratadosPorIdUsuario(Int16 idUsuarios)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                Int16 serviciosRepetidos = Convert.ToInt16(
                    (from cantServi in Chambix.tb_Servicio
                     where cantServi.estadoServicio == true
                     && cantServi.idUsuario== idUsuarios
                     select cantServi).Count()
                    );
                return serviciosRepetidos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
