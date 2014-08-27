namespace TrainingSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserEvents",
                c => new
                    {
                        UserEventID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EventID = c.Int(nullable: false),
                        Attending = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserEventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserEvents");
        }
    }
}
