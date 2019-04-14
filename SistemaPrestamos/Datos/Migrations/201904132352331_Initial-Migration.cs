namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Correo = c.String(),
                        Nombre = c.String(),
                        Edad = c.Int(nullable: false),
                        SalarioBruto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Distrito = c.String(),
                        EsNuevo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
