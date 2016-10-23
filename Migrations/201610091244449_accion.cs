namespace Papa.Core.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class accion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        isDeleted = c.Boolean(nullable: false),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        IdCampana = c.Int(nullable: false),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Accion_IsDeleted", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Campana",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAccion = c.Int(nullable: false),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accion", t => t.IdAccion)
                .Index(t => t.IdAccion);
            
            DropTable("dbo.Prueba");
            DropTable("dbo.Prueba1");
            DropTable("dbo.Prueba2");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prueba2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCampo = c.String(),
                        ValorAnterior = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prueba1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCampo = c.String(),
                        ValorAnterior = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prueba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreCampo = c.String(),
                        ValorAnterior = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Campana", "IdAccion", "dbo.Accion");
            DropIndex("dbo.Campana", new[] { "IdAccion" });
            DropTable("dbo.Campana");
            DropTable("dbo.Accion",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Accion_IsDeleted", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
