namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbMotoDelivery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        num_factura = c.Int(nullable: false, identity: true),
                        codigo_viaje = c.Int(nullable: false),
                        cliente = c.Int(nullable: false),
                        id_moto = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        importe = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                        estado_pago = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.num_factura)
                .ForeignKey("dbo.Traslado", t => t.codigo_viaje)
                .ForeignKey("dbo.Usuario", t => t.cliente)
                .ForeignKey("dbo.Usuario_Moto", t => t.id_moto)
                .Index(t => t.codigo_viaje)
                .Index(t => t.cliente)
                .Index(t => t.id_moto);
            
            CreateTable(
                "dbo.Traslado",
                c => new
                    {
                        codigo_tras = c.Int(nullable: false, identity: true),
                        usuario_id = c.Int(nullable: false),
                        id_moto = c.Int(),
                        tarifa = c.String(nullable: false, maxLength: 50, unicode: false),
                        calle_in = c.String(nullable: false, maxLength: 50, unicode: false),
                        calle_fn = c.String(nullable: false, maxLength: 50, unicode: false),
                        estado_viaje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.codigo_tras)
                .ForeignKey("dbo.Usuario", t => t.usuario_id)
                .ForeignKey("dbo.Usuario_Moto", t => t.id_moto)
                .Index(t => t.usuario_id)
                .Index(t => t.id_moto);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        id_Usuario = c.Int(nullable: false, identity: true),
                        tipo_usuario = c.String(nullable: false, maxLength: 50, unicode: false),
                        nombre = c.String(nullable: false, unicode: false, storeType: "text"),
                        apellido = c.String(nullable: false, unicode: false, storeType: "text"),
                        pais = c.String(nullable: false, unicode: false, storeType: "text"),
                        doc_tipo = c.String(nullable: false, maxLength: 50, unicode: false),
                        num_doc = c.String(nullable: false, maxLength: 50, unicode: false),
                        f_nac = c.DateTime(nullable: false, storeType: "date"),
                        calle = c.String(nullable: false, maxLength: 50, unicode: false),
                        altura = c.String(nullable: false, maxLength: 50, unicode: false),
                        dep = c.String(maxLength: 50, unicode: false),
                        email = c.String(nullable: false, maxLength: 50, unicode: false),
                        cp = c.String(maxLength: 50, unicode: false),
                        contrasena = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id_Usuario);
            
            CreateTable(
                "dbo.Moto",
                c => new
                    {
                        patente = c.Int(nullable: false),
                        usuario_id = c.Int(nullable: false),
                        modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        registro = c.String(nullable: false, maxLength: 50, unicode: false),
                        seguro = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.patente)
                .ForeignKey("dbo.Usuario", t => t.usuario_id)
                .Index(t => t.usuario_id);
            
            CreateTable(
                "dbo.Usuario_Moto",
                c => new
                    {
                        id_moto = c.Int(nullable: false),
                        patente = c.Int(nullable: false),
                        estado_moto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_moto)
                .ForeignKey("dbo.Usuario", t => t.id_moto)
                .Index(t => t.id_moto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario_Moto", "id_moto", "dbo.Usuario");
            DropForeignKey("dbo.Traslado", "id_moto", "dbo.Usuario_Moto");
            DropForeignKey("dbo.Factura", "id_moto", "dbo.Usuario_Moto");
            DropForeignKey("dbo.Traslado", "usuario_id", "dbo.Usuario");
            DropForeignKey("dbo.Moto", "usuario_id", "dbo.Usuario");
            DropForeignKey("dbo.Factura", "cliente", "dbo.Usuario");
            DropForeignKey("dbo.Factura", "codigo_viaje", "dbo.Traslado");
            DropIndex("dbo.Usuario_Moto", new[] { "id_moto" });
            DropIndex("dbo.Moto", new[] { "usuario_id" });
            DropIndex("dbo.Traslado", new[] { "id_moto" });
            DropIndex("dbo.Traslado", new[] { "usuario_id" });
            DropIndex("dbo.Factura", new[] { "id_moto" });
            DropIndex("dbo.Factura", new[] { "cliente" });
            DropIndex("dbo.Factura", new[] { "codigo_viaje" });
            DropTable("dbo.Usuario_Moto");
            DropTable("dbo.Moto");
            DropTable("dbo.Usuario");
            DropTable("dbo.Traslado");
            DropTable("dbo.Factura");
        }
    }
}
