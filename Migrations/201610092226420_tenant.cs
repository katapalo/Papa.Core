namespace Papa.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tenant : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accion", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.Campana", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.LogCambioHead", "ClientId", c => c.Int(nullable: false));
            AddColumn("dbo.LogCambioDetail", "ClientId", c => c.Int(nullable: false));
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
