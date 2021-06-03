using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTestimonio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTestimonio
    {
        [OperationContract]
        Boolean InsertTestimonio(TestimonioBE objTestimonioBE);

        [OperationContract]
        Boolean UpdateTestimonio(TestimonioBE objTestimonioBE);

        [OperationContract]
        Boolean DeleteTestimonio(Int32 idTestimonio);

        [OperationContract]
        TestimonioBE GetTestimonio(Int32 idTestimonio);

        [OperationContract]
        List<TestimonioBE> GetAllTestimonio();

    }

    public class TestimonioBE
    {
        private Int32 mvaridTestimonio;
        private Int32 mvaridUsuario;
        private Int32 mvaridPost;
        private String mvarTituloTestimonio;
        private String mvarDescripcionTestimonio;
        private bool mvarEstadoTestimonio;
        private DateTime mvarcreate_at;
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

        [DataMember]
        public Int32 idTestimonio
        {
            get { return mvaridTestimonio; }
            set { mvaridTestimonio = value; }
        }


        [DataMember]
        public Int32 idUsuario
        {
            get { return mvaridUsuario; }
            set { mvaridUsuario = value; }
        }
        [DataMember]
        public Int32 idPost
        {
            get { return mvaridPost; }
            set { mvaridPost = value; }
        }

        [DataMember]
        public String tituloTestimonio
        {
            get { return mvarTituloTestimonio; }
            set { mvarTituloTestimonio = value; }
        }

        [DataMember]
        public String descripcionTestimonio
        {
            get { return mvarDescripcionTestimonio; }
            set { mvarDescripcionTestimonio = value; }
        }

        [DataMember]
        public bool estadoTestimonio
        {
            get { return mvarEstadoTestimonio; }
            set { mvarEstadoTestimonio = value; }
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
