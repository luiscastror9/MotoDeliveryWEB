namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moto")]
    public partial class Moto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int patente { get; set; }

        public int usuario_id { get; set; }

        [Required]
        [StringLength(50)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string registro { get; set; }

        [Required]
        [StringLength(50)]
        public string seguro { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
