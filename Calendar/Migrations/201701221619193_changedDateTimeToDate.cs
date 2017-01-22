namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDateTimeToDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "ReleaseDate_Id", c => c.Guid());
            CreateIndex("dbo.Dates", "ReleaseDate_Id");
            AddForeignKey("dbo.Dates", "ReleaseDate_Id", "dbo.Dates", "Id");
            DropColumn("dbo.Dates", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dates", "ReleaseDate", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Dates", "ReleaseDate_Id", "dbo.Dates");
            DropIndex("dbo.Dates", new[] { "ReleaseDate_Id" });
            DropColumn("dbo.Dates", "ReleaseDate_Id");
        }
    }
}
