//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.facturas = new HashSet<factura>();
            this.motoes = new HashSet<moto>();
            this.trasladoes = new HashSet<traslado>();
        }
    
        public int usuario_id { get; set; }
        public string tipo_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pais { get; set; }
        public string doc_tipo { get; set; }
        public string num_doc { get; set; }
        public System.DateTime f_nac { get; set; }
        public string calle { get; set; }
        public string altura { get; set; }
        public string dep { get; set; }
        public string email { get; set; }
        public string cp { get; set; }
        public string contrasena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<moto> motoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<traslado> trasladoes { get; set; }
        public virtual usuario_moto usuario_moto { get; set; }
    }
}
