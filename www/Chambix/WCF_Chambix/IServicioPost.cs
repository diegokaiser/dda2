using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chambix
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPost" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPost
    {
        [OperationContract]
        Boolean InsertPost(PostBE objPostBE);

        [OperationContract]
        Boolean UpdatePost(PostBE objPostBE);

        [OperationContract]
        Boolean LogicDeletePost(PostBE objPostBE);

        [OperationContract]
        PostBE GetPost(Int16 idPost);

        [OperationContract]
        List<PostBE> GetAllPosts();

        [OperationContract]
        List<PostBE> GetAllPostsPorCategoria(Int16 idSubCategoria);

        [OperationContract]
        Int16 GetContarPostPorCategoria(Int16 idPost);
    }
    [DataContract]
    [Serializable]
    public class PostBE
    {
        private Int16 mvaridPost;
        private Int16 mvaridUsuario;
        private Int16 mvaridSubcategoria;
        private Int16 mvaridDistrito;
        private String mvartituloPost;
        private String mvarNombreCategoria;
        private String mvarNombreUsuario;
        private String mvardescripcionPost;
        private Decimal mvarprecioPost;
        private String mvarimagenPost;
        private Int16 mvarvaloracionPost;
        private Int16 mvarestadoPost;
        private DateTime mvarcreate_at;
        private String mvarcreate_by;
        private DateTime mvarupdate_at;
        private String mvarupdate_by;

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
        public Int16 idSubcategoria
        {
            get { return mvaridSubcategoria; }
            set { mvaridSubcategoria = value; }
        }

        [DataMember]
        public Int16 idDistrito
        {
            get { return mvaridDistrito; }
            set { mvaridDistrito = value; }
        }

        [DataMember]
        public String tituloPost
        {
            get { return mvartituloPost; }
            set { mvartituloPost = value; }
        }

        [DataMember]
        public String descripcionPost
        {
            get { return mvardescripcionPost; }
            set { mvardescripcionPost = value; }
        }

        [DataMember]
        public Decimal precioPost
        {
            get { return mvarprecioPost; }
            set { mvarprecioPost = value; }
        }

        [DataMember]
        public String imagenPost
        {
            get { return mvarimagenPost; }
            set { mvarimagenPost = value; }
        }

        [DataMember]
        public Int16 valoracionPost
        {
            get { return mvarvaloracionPost; }
            set { mvarvaloracionPost = value; }
        }

        [DataMember]
        public Int16 estadoPost
        {
            get { return mvarestadoPost; }
            set { mvarestadoPost = value; }
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
        [DataMember]
        public String NombreCategoria
        {
            get { return mvarNombreCategoria; }
            set { mvarNombreCategoria = value; }
        }
        [DataMember]
        public String NombreUsuario
        {
            get { return mvarNombreUsuario; }
            set { mvarNombreUsuario = value; }
        }
    }
}
