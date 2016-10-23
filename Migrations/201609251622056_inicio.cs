namespace Papa.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogCambioHead",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Entidad = c.String(),
                        FechaCambio = c.DateTime(nullable: false),
                        TipoCambio = c.String(),
                        Login = c.String(),
                        Nombre = c.String(),
                        Rol = c.String(),
                        IdEntidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogCambioDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCampo = c.String(),
                        ValorAnterior = c.String(),
                        ValorActual = c.String(),
                        LogCambioHeadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LogCambioHead", t => t.LogCambioHeadId)
                .Index(t => t.LogCambioHeadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LogCambioDetail", "LogCambioHeadId", "dbo.LogCambioHead");
            DropIndex("dbo.LogCambioDetail", new[] { "LogCambioHeadId" });
            DropTable("dbo.LogCambioDetail");
            DropTable("dbo.LogCambioHead");
        }
    }
}
