namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("traslado")]
    public partial class traslado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public traslado()
        {
            estado_viaje = new HashSet<estado_viaje>();
            facturas = new HashSet<factura>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codigo_tras { get; set; }

        public int usuario_id { get; set; }

        public int id_moto { get; set; }

        [Required]
        [StringLength(50)]
        public string tarifa { get; set; }

        [Required]
        [StringLength(50)]
        public string calle_in { get; set; }

        [Required]
        [StringLength(50)]
        public string altura_in { get; set; }

        [Required]
        [StringLength(50)]
        public string piso_in { get; set; }

        [Required]
        [StringLength(50)]
        public string dep_in { get; set; }

        [Required]
        [StringLength(50)]
        public string calle_fn { get; set; }

        [Required]
        [StringLength(50)]
        public string altura_fn { get; set; }

        [Required]
        [StringLength(50)]
        public string piso_fn { get; set; }

        [Required]
        [StringLength(50)]
        public string dep_fn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estado_viaje> estado_viaje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> facturas { get; set; }

        public virtual usuario usuario { get; set; }

        public virtual usuario_moto usuario_moto { get; set; }
    }
}
