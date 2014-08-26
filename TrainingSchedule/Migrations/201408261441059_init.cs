namespace TrainingSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Syllabus",
                c => new
                    {
                        SyllabusID = c.Int(nullable: false, identity: true),
                        SyllabusName = c.String(nullable: false),
                        Description = c.String(),
                        TechID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SyllabusID)
                .ForeignKey("dbo.Technologies", t => t.TechID, cascadeDelete: true)
                .Index(t => t.TechID);
            
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        TechID = c.Int(nullable: false, identity: true),
                        TechName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TechID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        Location = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        TechID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID)
                .ForeignKey("dbo.Technologies", t => t.TechID, cascadeDelete: true)
                .Index(t => t.TechID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Events", new[] { "TechID" });
            DropIndex("dbo.Syllabus", new[] { "TechID" });
            DropForeignKey("dbo.Events", "TechID", "dbo.Technologies");
            DropForeignKey("dbo.Syllabus", "TechID", "dbo.Technologies");
            DropTable("dbo.Events");
            DropTable("dbo.Technologies");
            DropTable("dbo.Syllabus");
        }
    }
}
