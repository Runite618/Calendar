namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed_key_from_event_to_date : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dates");
            AlterColumn("dbo.Dates", "Event", c => c.String());
            AddPrimaryKey("dbo.Dates", "ReleaseDate");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Dates");
            AlterColumn("dbo.Dates", "Event", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Dates", "Event");
        }
    }
}
