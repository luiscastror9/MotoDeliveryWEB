namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Facturas = new HashSet<Factura>();
            Motoes = new HashSet<Moto>();
            Traslados = new HashSet<Traslado>();
        }

        [Key]
        public int id_Usuario { get; set; }

        [Required]
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
        [DataType(DataType.Date) ]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime f_nac { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Calle")]
        public string calle { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Altua")]
        public string altura { get; set; }

        [StringLength(50)]
        [Display(Name = "Departamento")]
        public string dep { get; set; }

        [StringLength(50)]
        [Display(Name = "Código Postal")]
        public string cp { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-Correo")]
        [StringLength(50)]
        public string email { get; set; }        

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        [StringLength(50)]
        public string contrasena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moto> Motoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traslado> Traslados { get; set; }

        public virtual Usuario_Moto Usuario_Moto { get; set; }
    }
}
