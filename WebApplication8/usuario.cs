namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity.Core;

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

        [Display(Name = "Id Usuario")]
        [Key]        
        public string usuario_id { get; set; }

        
        [StringLength(50)]
        [Display(Name = "Tipo de Usuario")]
        public string tipo_usuario { get; set; }
        

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [Display(Name = "País")]
        public string pais { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tipo de Documento")]
        public string doc_tipo { get; set; }
        

        [Required]
        [StringLength(50)]
        [Display(Name = "Número de Documento")]
        public string num_doc { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime f_nac { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Calle")]
        public string calle { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Altura")]
        public string altura { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Departamento")]
        public string dep { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        public bool emailconfirmado { get; set; }

        [Display(Name = "Código Postl")]
        [StringLength(50)]
        public string cp { get; set; }

        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string PasswordHash { get; set; }

        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("PasswordHash", ErrorMessage = "La contraseña y su confiormación no coincide.")]
        public string confirmarPasswordHash { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<moto> motoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<traslado> trasladoes { get; set; }

        public virtual usuario_moto usuario_moto { get; set; }
    }
}
