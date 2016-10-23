namespace Papa.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tenant2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accion", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Campana", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.LogCambioHead", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.LogCambioDetail", "ClientId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogCambioDetail", "ClientId");
            DropColumn("dbo.LogCambioHead", "ClientId");
            DropColumn("dbo.Campana", "ClientId");
            DropColumn("dbo.Accion", "ClientId");
        }
    }
}
