namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedIdToGuid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dates");
            DropColumn("dbo.Dates", "Id");
            AddColumn("dbo.Dates", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Dates", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Dates");
            DropColumn("dbo.Dates", "Id");
            AddColumn("dbo.Dates", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Dates", "Id");
        }
    }
}
