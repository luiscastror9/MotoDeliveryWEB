namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("factura")]
    public partial class factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int num_factura { get; set; }

        public int codigo_viaje { get; set; }

        [Required]
        [StringLength(128)]
        public string cliente { get; set; }

        [Required]
        [StringLength(128)]
        public string id_moto { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? importe { get; set; }

        [StringLength(50)]
        public string estado_pago { get; set; }

        public virtual traslado traslado { get; set; }

        public virtual usuario usuario { get; set; }

        public virtual usuario_moto usuario_moto { get; set; }
    }
}
