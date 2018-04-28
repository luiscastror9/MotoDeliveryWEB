namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuario")]
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            facturas = new HashSet<factura>();
            motoes = new HashSet<moto>();
            trasladoes = new HashSet<traslado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int usuario_id { get; set; }

        [Required]
        [StringLength(50)]
        public string tipo_usuario { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string apellido { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string pais { get; set; }

        [Required]
        [StringLength(50)]
        public string doc_tipo { get; set; }

        [Required]
        [StringLength(50)]
        public string num_doc { get; set; }

        [Column(TypeName = "date")]
        public DateTime f_nac { get; set; }

        [Required]
        [StringLength(50)]
        public string calle { get; set; }

        [Required]
        [StringLength(50)]
        public string altura { get; set; }

        [Required]
        [StringLength(50)]
        public string dep { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool EmailConfirmado { get; set; }

        [Required]
        [StringLength(50)]
        public string cp { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<moto> motoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<traslado> trasladoes { get; set; }

        public virtual usuario_moto usuario_moto { get; set; }
    }
}
