namespace Calendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dates",
                c => new
                    {
                        Event = c.String(nullable: false, maxLength: 128),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Event);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dates");
        }
    }
}
