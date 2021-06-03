using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReplica" en el código y en el archivo de configuración a la vez.
    public class ServicioReplica : IServicioReplica
    {
        public bool InsertReplica(ReplicaBE objReplicaBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Replica objReplica = new tb_Replica();

                objReplica.idUsuario = objReplicaBE.idUsuario;
                objReplica.idTestimonio = objReplicaBE.idTestimonio;
                objReplica.tituloReplica = objReplicaBE.tituloReplica;
                objReplica.descripcionReplica = objReplicaBE.descripcionReplica;

                Chambix.tb_Replica.Add(objReplica);
                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateReplica(ReplicaBE objReplicaBE)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Replica objReplica = (from objRep in Chambix.tb_Replica
                                         where objRep.idReplica== objReplicaBE.idReplica
                                         select objRep).FirstOrDefault();

                objReplica.idReplica = objReplicaBE.idReplica;
                objReplica.idUsuario = objReplicaBE.idUsuario;
                objReplica.idTestimonio = objReplicaBE.idTestimonio;
                objReplica.tituloReplica = objReplicaBE.tituloReplica;
                objReplica.descripcionReplica = objReplicaBE.descripcionReplica;
                objReplica.estadoReplica = objReplicaBE.estadoReplica;

                Chambix.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool DeleteReplica(int idReplica)
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Replica objReplica = (from objRep in Chambix.tb_Replica
                                         where objRep.idReplica == idReplica
                                         select objRep).FirstOrDefault();

                Chambix.tb_Replica.Remove(objReplica);
                Chambix.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ReplicaBE> GetAllReplica()
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                List<ReplicaBE> objReplicaList = new List<ReplicaBE>();

                var query = (from objRep in Chambix.tb_Replica
                             select objRep);
                foreach (var objReplica in query)
                {
                    ReplicaBE objReplicaBE = new ReplicaBE();

                    objReplicaBE.idTestimonio = Convert.ToInt32(objReplica.idReplica);

                    objReplicaBE.idReplica = objReplica.idReplica;
                    objReplicaBE.idUsuario = objReplica.idUsuario;
                    objReplicaBE.idTestimonio = objReplica.idTestimonio;
                    objReplicaBE.tituloReplica = objReplica.tituloReplica;
                    objReplicaBE.descripcionReplica = objReplica.descripcionReplica;
                    objReplicaBE.estadoReplica = (bool)objReplica.estadoReplica;
                    objReplicaBE.create_at = (DateTime)objReplica.create_at;
  

                    if (objReplica.update_at != null)
                    {
                        objReplicaBE.update_at = (DateTime)objReplica.update_at;
                    }

                    objReplicaList.Add(objReplicaBE);
                }
                return objReplicaList;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ReplicaBE GetReplica(int idReplica )
        {
            SistemaServiciosEntities Chambix = new SistemaServiciosEntities();
            try
            {
                tb_Replica objReplica = (from objRep in Chambix.tb_Replica
                                         where objRep.idReplica == idReplica
                                         select objRep).FirstOrDefault();

                ReplicaBE objReplicaBE = new ReplicaBE();

                objReplicaBE.idReplica = objReplica.idReplica;
                objReplicaBE.idUsuario = objReplica.idUsuario;
                objReplicaBE.idTestimonio = objReplica.idTestimonio;
                objReplicaBE.tituloReplica = objReplica.tituloReplica;
                objReplicaBE.descripcionReplica = objReplica.descripcionReplica;
                objReplicaBE.estadoReplica = (bool)objReplica.estadoReplica;
                objReplicaBE.create_at = (DateTime)objReplica.create_at;

                if (objReplica.update_at != null)
                {
                    objReplicaBE.update_at = (DateTime)objReplica.update_at;
                }



                return objReplicaBE;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
