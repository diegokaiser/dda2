//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Chambix
{
    using System;
    
    public partial class usp_CategoriaLike_Result
    {
        public int idPost { get; set; }
        public int idUsuario { get; set; }
        public int idSubcategoria { get; set; }
        public Nullable<byte> idDistrito { get; set; }
        public string tituloPost { get; set; }
        public string descripcionPost { get; set; }
        public string imagenPost { get; set; }
        public Nullable<decimal> precioPost { get; set; }
        public Nullable<int> valoracionPost { get; set; }
        public Nullable<bool> estadoPost { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }
        public string nombreDistrito { get; set; }
        public string nombreCategoria { get; set; }
        public string nombreSubCategoria { get; set; }
    }
}
