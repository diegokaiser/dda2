using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDistrito" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDistrito
    {

        [OperationContract]
        List<DistritoBE> GetAllDistritos();
    }

    public class DistritoBE
    {
        private Int16 varidDistrito;
        private String varnombreDistrito;
        [DataMember]
        public Int16 idDistrito
        {
            get { return varidDistrito; }
            set { varidDistrito = value; }
        }

        [DataMember]
        public String nombreDistrito
        {
            get { return varnombreDistrito; }
            set { varnombreDistrito = value; }
        }
    }

}
