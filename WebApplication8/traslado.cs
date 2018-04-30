namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Traslado")]
    public partial class Traslado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Traslado()
        {
            Facturas = new HashSet<Factura>();
        }

        [Key]
        public int codigo_tras { get; set; }

        public int usuario_id { get; set; }

        public int? id_moto { get; set; }

        [Required]
        [StringLength(50)]
        public string tarifa { get; set; }

        [Required]
        [StringLength(50)]
        public string calle_in { get; set; }

        [Required]
        [StringLength(50)]
        public string calle_fn { get; set; }

        public int estado_viaje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario_Moto Usuario_Moto { get; set; }
    }
}
