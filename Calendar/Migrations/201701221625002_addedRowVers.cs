namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRowVers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dates", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dates", "RowVersion");
        }
    }
}
