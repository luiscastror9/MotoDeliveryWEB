namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class estado_viaje
    {
        [Key]
        [Column("estado_viaje")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int estado_viaje1 { get; set; }

        public int? codigo_tras { get; set; }

        public virtual traslado traslado { get; set; }
    }
}
