namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedReleaseDateToDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "_Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Dates", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dates", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Dates", "_Date");
        }
    }
}
