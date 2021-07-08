using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCategoria" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCategoria
    {
        [OperationContract]
        List<CategoriaBE> GetAllCategoria();

        [OperationContract]
        Boolean InsertCategoria(CategoriaBE objcategoriaBE);

        [OperationContract]
        Boolean UpdateCategoria(CategoriaBE objcategoriaBE);

        [OperationContract]
        Boolean DeleteCategoria(Int16 id);


    }

    [DataContract]
    [Serializable]

    public class CategoriaBE
    {
        private Int16 mvaridCategoria;
        private String mvarnombreCategoria;
        private DateTime mvarcreate_at;
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

        [DataMember]
        public Int16 idCategoria
        {
            set { mvaridCategoria = value; }
            get { return mvaridCategoria; }
        }

        [DataMember]
        public string nombreCategoria
        {
            set { mvarnombreCategoria = value; }
            get { return mvarnombreCategoria; }
        }
        [DataMember]
        public DateTime create_at
        {
            set { mvarcreate_at = value; }
            get { return mvarcreate_at; }
        }
        [DataMember]
        public string create_by
        {
            set { mvarcreate_by = value; }
            get { return mvarcreate_by; }
        }
        [DataMember]
        public DateTime update_at
        {
            set { mvarupdate_at = value; }
            get { return mvarupdate_at; }
        }
        [DataMember]
        public string update_by
        {
            set { mvarupdate_by = value; }
            get { return mvarupdate_by; }
        }
    }


}
