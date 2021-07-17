using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        Boolean InsertUser(UserBE objPostBE);

        [OperationContract]
        Boolean UpdateUser(UserBE objUserBE);

        [OperationContract]
        Boolean LogicDeleteUser(UserBE objUserBE);

        [OperationContract]
        UserBE GetUser(Int16 idUser);

        [OperationContract]
        List<UserBE> GetAllUsers();

        [OperationContract]
        List<UserBE> GetAllUsersClients();

        [OperationContract]
        List<UserBE> GetAllUsersProfesionals();

        [OperationContract]
        List<UserBE> GetAllUsersAdmins();
    }
    [DataContract]
    [Serializable]
    public class UserBE
    {
        private Int16 mvaridUsuario;
        private Int16 mvartipoUsuario;
        private Int16 mvarestadoUsuario;
        private String mvarnombreUsuario;
        private String mvarapellidoUsuario;
        private String mvarcontrasenaUsuario;
        private Int16 mvaridDistrito;
        private String mvaremailUsuario;
        private String mvarcellUsuario;
        private Int16 mvarrankUsuario;
        private String mvarwspUsuario;
        private String mvarocupacionUsuario;
        private Int16 mvaridTipoCuenta;
        private DateTime mvartiempoCuenta;
        private DateTime mvarcreate_at;
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

        [DataMember]
        public Int16 idUsuario
        {
            get { return mvaridUsuario; }
            set { mvaridUsuario = value; }
        }

        [DataMember]
        public Int16 tipoUsuario
        {
            get { return mvartipoUsuario; }
            set { mvartipoUsuario = value; }
        }

        [DataMember]
        public Int16 estadoUsuario
        {
            get { return mvarestadoUsuario; }
            set { mvarestadoUsuario = value; }
        }

        [DataMember]
        public String nombreUsuario
        {
            get { return mvarnombreUsuario; }
            set { mvarnombreUsuario = value; }
        }

        [DataMember]
        public String apellidoUsuario
        {
            get { return mvarapellidoUsuario; }
            set { mvarapellidoUsuario = value; }
        }

        [DataMember]
        public String contrasenaUsuario
        {
            get { return mvarcontrasenaUsuario; }
            set { mvarcontrasenaUsuario = value; }
        }

        [DataMember]
        public Int16 idDistrito
        {
            get { return mvaridDistrito; }
            set { mvaridDistrito = value; }
        }

        [DataMember]
        public String emailUsuario
        {
            get { return mvaremailUsuario; }
            set { mvaremailUsuario = value; }
        }

        [DataMember]
        public String cellUsuario
        {
            get { return mvarcellUsuario; }
            set { mvarcellUsuario = value; }
        }

        [DataMember]
        public Int16 rankUsuario
        {
            get { return mvarrankUsuario; }
            set { mvarrankUsuario = value; }
        }

        [DataMember]
        public String wspUsuario
        {
            get { return mvarwspUsuario; }
            set { mvarwspUsuario = value; }
        }

        [DataMember]
        public String ocupacionUsuario
        {
            get { return mvarocupacionUsuario; }
            set { mvarocupacionUsuario = value; }
        }

        [DataMember]
        public Int16 idTipoCuenta
        {
            get { return mvaridTipoCuenta; }
            set { mvaridTipoCuenta = value; }
        }

        [DataMember]
        public DateTime tiempoCuenta
        {
            get { return mvartiempoCuenta; }
            set { mvartiempoCuenta = value; }
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
