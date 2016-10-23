namespace Papa.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prueba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCampo = c.String(),
                        ValorAnterior = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prueba");
        }
    }
}
