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
    
    public partial class tb_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Usuario()
        {
            this.tb_Post = new HashSet<tb_Post>();
            this.tb_Replica = new HashSet<tb_Replica>();
            this.tb_Servicio = new HashSet<tb_Servicio>();
            this.tb_Testimonio = new HashSet<tb_Testimonio>();
        }
    
        public int idUsuario { get; set; }
        public Nullable<byte> tipoUsuario { get; set; }
        public Nullable<bool> estadoUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }
        public string contrasenaUsuario { get; set; }
        public Nullable<byte> idDistrito { get; set; }
        public string emailUsuario { get; set; }
        public string cellUsuario { get; set; }
        public Nullable<int> rankUsuario { get; set; }
        public string wspUsuario { get; set; }
        public string ocupacionUsuario { get; set; }
        public byte idTipoCuenta { get; set; }
        public Nullable<System.DateTime> tiempoCuenta { get; set; }
        public System.DateTime create_at { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_at { get; set; }
        public string update_by { get; set; }
    
        public virtual tb_Distrito tb_Distrito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Post> tb_Post { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Replica> tb_Replica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Servicio> tb_Servicio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Testimonio> tb_Testimonio { get; set; }
        public virtual tb_TipoCuenta tb_TipoCuenta { get; set; }
    }
}
