namespace Bike2Go.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExperienceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "ExperienceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Members", "ExperienceId");
            AddForeignKey("dbo.Members", "ExperienceId", "dbo.Experiences", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "ExperienceId", "dbo.Experiences");
            DropIndex("dbo.Members", new[] { "ExperienceId" });
            DropColumn("dbo.Members", "ExperienceId");
            DropTable("dbo.Experiences");
        }
    }
}
