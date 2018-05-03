namespace WebApplication8
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbMotoDelivery : DbContext
    {
        public DbMotoDelivery()
            : base("name=DbMotoDelivery")
        {
        }

        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Moto> Motoes { get; set; }
        public virtual DbSet<Traslado> Traslados { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Usuario_Moto> Usuario_Moto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                .Property(e => e.importe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Factura>()
                .Property(e => e.estado_pago)
                .IsUnicode(false);

            modelBuilder.Entity<Moto>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Moto>()
                .Property(e => e.registro)
                .IsUnicode(false);

            modelBuilder.Entity<Moto>()
                .Property(e => e.seguro)
                .IsUnicode(false);

            modelBuilder.Entity<Traslado>()
                .Property(e => e.tarifa)
                .IsUnicode(false);

            modelBuilder.Entity<Traslado>()
                .Property(e => e.calle_in)
                .IsUnicode(false);

            modelBuilder.Entity<Traslado>()
                .Property(e => e.calle_fn)
                .IsUnicode(false);

            modelBuilder.Entity<Traslado>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Traslado)
                .HasForeignKey(e => e.codigo_viaje)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.tipo_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.doc_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.num_doc)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.altura)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.dep)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Moto)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.usuario_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Traslado)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.usuario_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasOptional(e => e.Usuario_Moto)
                .WithRequired(e => e.Usuario);

            modelBuilder.Entity<Usuario_Moto>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Usuario_Moto)
                .WillCascadeOnDelete(false);
        }
    }
}
