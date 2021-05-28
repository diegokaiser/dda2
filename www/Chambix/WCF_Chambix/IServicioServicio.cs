using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioServicio
    {
        [OperationContract]
        Boolean InsertServicio(ServicioBE objServicioBE);

        [OperationContract]
        Boolean UpdateServicio(ServicioBE objServicioBE);

        //[OperationContract]
        //Boolean LogicDeleteServicio(ServicioBE objPostBE);

        [OperationContract]
        ServicioBE GetServicio(Int16 idServicio); //modificar

        [OperationContract]
        List<ServicioBE> GetAllServicio();

    }
    [DataContract]
    [Serializable]

    public class ServicioBE
    {
        private Int16 mvaridServicio;
        private Int16 mvaridPost;
        private Int16 mvaridUsuario;
        private Byte mvarEstadoServicio; 
        private DateTime mvarcreate_at; 
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

        [DataMember]
        public Int16 idServicio
        {
            get { return mvaridServicio; }
            set { mvaridServicio = value; }
        }
        [DataMember]
        public Int16 idPost
        {
            get { return mvaridPost; }
            set { mvaridPost = value; }
        }

        [DataMember]
        public Int16 idUsuario
        {
            get { return mvaridUsuario; }
            set { mvaridUsuario = value; }
        }

        [DataMember]
        public Byte estadoServicio
        {
            get { return mvarEstadoServicio; }
            set { mvarEstadoServicio = value; }
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
