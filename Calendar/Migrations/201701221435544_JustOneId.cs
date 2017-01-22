namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JustOneId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dates");
            DropColumn("dbo.Dates", "ReleaseDateId");
            DropColumn("dbo.Dates", "EventId");
            AddColumn("dbo.Dates", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Dates", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dates", "EventId", c => c.Int(nullable: false));
            AddColumn("dbo.Dates", "ReleaseDateId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Dates");
            DropColumn("dbo.Dates", "Id");
            AddPrimaryKey("dbo.Dates", "ReleaseDateId");
        }
    }
}
