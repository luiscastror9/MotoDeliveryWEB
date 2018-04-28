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

        public virtual DbSet<estado_viaje> estado_viaje { get; set; }
        public virtual DbSet<factura> facturas { get; set; }
        public virtual DbSet<moto> motoes { get; set; }
        public virtual DbSet<traslado> trasladoes { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<usuario_moto> usuario_moto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<factura>()
                .Property(e => e.importe)
                .HasPrecision(18, 0);

            modelBuilder.Entity<factura>()
                .Property(e => e.estado_pago)
                .IsUnicode(false);

            modelBuilder.Entity<moto>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<moto>()
                .Property(e => e.registro)
                .IsUnicode(false);

            modelBuilder.Entity<moto>()
                .Property(e => e.seguro)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.tarifa)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.calle_in)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.altura_in)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.piso_in)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.dep_in)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.calle_fn)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.altura_fn)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.piso_fn)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .Property(e => e.dep_fn)
                .IsUnicode(false);

            modelBuilder.Entity<traslado>()
                .HasMany(e => e.facturas)
                .WithRequired(e => e.traslado)
                .HasForeignKey(e => e.codigo_viaje)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.tipo_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.pais)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.doc_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.num_doc)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.altura)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.dep)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.facturas)
                .WithRequired(e => e.usuario)
                .HasForeignKey(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.motoes)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.trasladoes)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasOptional(e => e.usuario_moto)
                .WithRequired(e => e.usuario);

            modelBuilder.Entity<usuario_moto>()
                .HasMany(e => e.facturas)
                .WithRequired(e => e.usuario_moto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario_moto>()
                .HasMany(e => e.trasladoes)
                .WithRequired(e => e.usuario_moto)
                .WillCascadeOnDelete(false);
        }
    }
}
