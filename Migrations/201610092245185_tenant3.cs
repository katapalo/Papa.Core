namespace Papa.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tenant3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Accion", "ClientId");
            DropColumn("dbo.Campana", "ClientId");
            DropColumn("dbo.LogCambioHead", "ClientId");
            DropColumn("dbo.LogCambioDetail", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogCambioDetail", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.LogCambioHead", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Campana", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Accion", "ClientId", c => c.Guid(nullable: false));
        }
    }
}
