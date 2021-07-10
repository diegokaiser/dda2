using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioReplica" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioReplica
    {
        [OperationContract]
        Boolean InsertReplica(ReplicaBE objReplicaBE);

        [OperationContract]
        Boolean UpdateReplica(ReplicaBE objReplicaBE);

        [OperationContract]
        Boolean DeleteReplica(Int32 idReplica);

        [OperationContract]
        ReplicaBE GetReplica(Int32 idReplica);

        [OperationContract]
        List<ReplicaBE> GetAllReplica();

    }


    public class ReplicaBE
    {
        private Int32 mvaridReplica;
        private Int32 mvaridUsuario;
        private Int32 mvaridTestimonio;
        private String mvarTituloReplica;
        private String mvarDescripcionReplica;
        private bool mvarEstadoReplica;
        private DateTime mvarcreate_at;
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

        [DataMember]
        public Int32 idReplica
        {
            get { return mvaridReplica; }
            set { mvaridReplica = value; }
        }


        [DataMember]
        public Int32 idUsuario
        {
            get { return mvaridUsuario; }
            set { mvaridUsuario = value; }
        }
        [DataMember]
        public Int32 idTestimonio
        {
            get { return mvaridTestimonio; }
            set { mvaridTestimonio = value; }
        }

        [DataMember]
        public String tituloReplica
        {
            get { return mvarTituloReplica; }
            set { mvarTituloReplica = value; }
        }

        [DataMember]
        public String descripcionReplica
        {
            get { return mvarDescripcionReplica; }
            set { mvarDescripcionReplica = value; }
        }

        [DataMember]
        public bool estadoReplica
        {
            get { return mvarEstadoReplica; }
            set { mvarEstadoReplica = value; }
        }

        [DataMember]
        public DateTime create_at
        {
            get { return mvarcreate_at; }
            set { mvarcreate_at = value; }
        }

        [DataMember]
        public String create_by
        {
            get { return mvarcreate_by; }
            set { mvarcreate_by = value; }
        }

        [DataMember]
        public DateTime update_at
        {
            get { return mvarupdate_at; }
            set { mvarupdate_at = value; }
        }

        [DataMember]
        public String update_by
        {
            get { return mvarupdate_by; }
            set { mvarupdate_by = value; }
        }

    }
}
