namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbMotoDelivery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.usuario",
                c => new
                    {
                        usuario_id = c.String(nullable: false, maxLength: 128),
                        tipo_usuario = c.String(nullable: false, maxLength: 50, unicode: false),
                        nombre = c.String(nullable: false, unicode: false, storeType: "text"),
                        apellido = c.String(nullable: false, unicode: false, storeType: "text"),
                        pais = c.String(nullable: false, unicode: false, storeType: "text"),
                        doc_tipo = c.String(nullable: false, maxLength: 50, unicode: false),
                        num_doc = c.String(nullable: false, maxLength: 50, unicode: false),
                        f_nac = c.DateTime(nullable: false, storeType: "date"),
                        calle = c.String(nullable: false, maxLength: 50, unicode: false),
                        altura = c.String(nullable: false, maxLength: 50, unicode: false),
                        dep = c.String(nullable: false, maxLength: 50, unicode: false),
                        email = c.String(nullable: false, maxLength: 50, unicode: false),
                        emailconfirmado = c.Boolean(nullable: false),
                        cp = c.String(nullable: false, maxLength: 50, unicode: false),
                        PasswordHash = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.usuario_id)
                .ForeignKey("dbo.AspNetUsers", t => t.usuario_id)
                .Index(t => t.usuario_id);
            
            CreateTable(
                "dbo.factura",
                c => new
                    {
                        num_factura = c.Int(nullable: false),
                        codigo_viaje = c.Int(nullable: false),
                        cliente = c.String(nullable: false, maxLength: 128),
                        id_moto = c.String(nullable: false, maxLength: 128),
                        fecha = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        importe = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        estado_pago = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.num_factura)
                .ForeignKey("dbo.traslado", t => t.codigo_viaje)
                .ForeignKey("dbo.usuario_moto", t => t.id_moto)
                .ForeignKey("dbo.usuario", t => t.cliente)
                .Index(t => t.codigo_viaje)
                .Index(t => t.cliente)
                .Index(t => t.id_moto);
            
            CreateTable(
                "dbo.traslado",
                c => new
                    {
                        codigo_tras = c.Int(nullable: false),
                        usuario_id = c.String(nullable: false, maxLength: 128),
                        id_moto = c.String(nullable: false, maxLength: 128),
                        tarifa = c.String(nullable: false, maxLength: 50, unicode: false),
                        calle_in = c.String(nullable: false, maxLength: 50, unicode: false),
                        altura_in = c.String(nullable: false, maxLength: 50, unicode: false),
                        piso_in = c.String(nullable: false, maxLength: 50, unicode: false),
                        dep_in = c.String(nullable: false, maxLength: 50, unicode: false),
                        calle_fn = c.String(nullable: false, maxLength: 50, unicode: false),
                        altura_fn = c.String(nullable: false, maxLength: 50, unicode: false),
                        piso_fn = c.String(nullable: false, maxLength: 50, unicode: false),
                        dep_fn = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.codigo_tras)
                .ForeignKey("dbo.usuario_moto", t => t.id_moto)
                .ForeignKey("dbo.usuario", t => t.usuario_id)
                .Index(t => t.usuario_id)
                .Index(t => t.id_moto);
            
            CreateTable(
                "dbo.estado_viaje",
                c => new
                    {
                        estado_viaje = c.Int(nullable: false),
                        codigo_tras = c.Int(),
                    })
                .PrimaryKey(t => t.estado_viaje)
                .ForeignKey("dbo.traslado", t => t.codigo_tras)
                .Index(t => t.codigo_tras);
            
            CreateTable(
                "dbo.usuario_moto",
                c => new
                    {
                        id_moto = c.String(nullable: false, maxLength: 128),
                        patente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_moto)
                .ForeignKey("dbo.usuario", t => t.id_moto)
                .Index(t => t.id_moto);
            
            CreateTable(
                "dbo.moto",
                c => new
                    {
                        patente = c.Int(nullable: false),
                        usuario_id = c.String(nullable: false, maxLength: 128),
                        modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        registro = c.String(nullable: false, maxLength: 50, unicode: false),
                        seguro = c.String(nullable: false, maxLength: 50, unicode: false),
                        foto = c.Binary(nullable: false, storeType: "image"),
                    })
                .PrimaryKey(t => t.patente)
                .ForeignKey("dbo.usuario", t => t.usuario_id)
                .Index(t => t.usuario_id);
            
            CreateTable(
                "dbo.__MigrationHistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 150),
                        ContextKey = c.String(nullable: false, maxLength: 300),
                        Model = c.Binary(nullable: false),
                        ProductVersion = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => new { t.MigrationId, t.ContextKey });
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.usuario", "usuario_id", "dbo.AspNetUsers");
            DropForeignKey("dbo.usuario_moto", "id_moto", "dbo.usuario");
            DropForeignKey("dbo.traslado", "usuario_id", "dbo.usuario");
            DropForeignKey("dbo.moto", "usuario_id", "dbo.usuario");
            DropForeignKey("dbo.factura", "cliente", "dbo.usuario");
            DropForeignKey("dbo.traslado", "id_moto", "dbo.usuario_moto");
            DropForeignKey("dbo.factura", "id_moto", "dbo.usuario_moto");
            DropForeignKey("dbo.factura", "codigo_viaje", "dbo.traslado");
            DropForeignKey("dbo.estado_viaje", "codigo_tras", "dbo.traslado");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.moto", new[] { "usuario_id" });
            DropIndex("dbo.usuario_moto", new[] { "id_moto" });
            DropIndex("dbo.estado_viaje", new[] { "codigo_tras" });
            DropIndex("dbo.traslado", new[] { "id_moto" });
            DropIndex("dbo.traslado", new[] { "usuario_id" });
            DropIndex("dbo.factura", new[] { "id_moto" });
            DropIndex("dbo.factura", new[] { "cliente" });
            DropIndex("dbo.factura", new[] { "codigo_viaje" });
            DropIndex("dbo.usuario", new[] { "usuario_id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.__MigrationHistory");
            DropTable("dbo.moto");
            DropTable("dbo.usuario_moto");
            DropTable("dbo.estado_viaje");
            DropTable("dbo.traslado");
            DropTable("dbo.factura");
            DropTable("dbo.usuario");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
        }
    }
}
