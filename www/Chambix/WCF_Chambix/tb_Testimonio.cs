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
    
    public partial class tb_Testimonio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Testimonio()
        {
            this.tb_Replica = new HashSet<tb_Replica>();
        }
    
        public int idTestimonio { get; set; }
        public int idUsuario { get; set; }
        public int idPost { get; set; }
        public string tituloTestimonio { get; set; }
        public string descripcionTestimonio { get; set; }
        public Nullable<bool> estadoTestimonio { get; set; }
        public System.DateTime create_at { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
        public string update_by { get; set; }
    
        public virtual tb_Post tb_Post { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Replica> tb_Replica { get; set; }
        public virtual tb_Usuario tb_Usuario { get; set; }
    }
}
