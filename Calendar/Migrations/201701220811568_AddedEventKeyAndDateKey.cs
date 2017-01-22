namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEventKeyAndDateKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dates");
            AddColumn("dbo.Dates", "ReleaseDateId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Dates", "EventId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Dates", "ReleaseDateId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Dates");
            DropColumn("dbo.Dates", "EventId");
            DropColumn("dbo.Dates", "ReleaseDateId");
            AddPrimaryKey("dbo.Dates", "ReleaseDate");
        }
    }
}
