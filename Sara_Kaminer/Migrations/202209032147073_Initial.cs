namespace Sara_Kaminer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        JobName = c.String(nullable: false),
                        JobDescription = c.String(),
                        CompanyName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        PredictedJobViews = c.Int(nullable: false),
                        DateModify = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JobId);
            
            CreateTable(
                "dbo.JobViews",
                c => new
                    {
                        JobViewId = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        DateView = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JobViewId)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobViews", "JobId", "dbo.Jobs");
            DropIndex("dbo.JobViews", new[] { "JobId" });
            DropTable("dbo.JobViews");
            DropTable("dbo.Jobs");
        }
    }
}
