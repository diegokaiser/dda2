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
    using System.Collections.Generic;
    
    public partial class tb_Servicio
    {
        public int idServicio { get; set; }
        public int idPost { get; set; }
        public int idUsuario { get; set; }
        public Nullable<bool> estadoServicio { get; set; }
        public System.DateTime create_at { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
        public string update_by { get; set; }
    
        public virtual tb_Post tb_Post { get; set; }
        public virtual tb_Usuario tb_Usuario { get; set; }
    }
}
