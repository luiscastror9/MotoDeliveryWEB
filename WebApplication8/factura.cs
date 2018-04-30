namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [Key]
        public int num_factura { get; set; }

        public int codigo_viaje { get; set; }

        public int cliente { get; set; }

        public int id_moto { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? importe { get; set; }

        [StringLength(50)]
        public string estado_pago { get; set; }

        public virtual Traslado Traslado { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario_Moto Usuario_Moto { get; set; }
    }
}
