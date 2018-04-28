namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("moto")]
    public partial class moto
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

        [Column(TypeName = "image")]
        [Required]
        public byte[] foto { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
