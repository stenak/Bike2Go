namespace Bike2Go.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fee = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        DurationInMonths = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "MembershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Members", "MembershipId");
            AddForeignKey("dbo.Members", "MembershipId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipId", "dbo.Memberships");
            DropIndex("dbo.Members", new[] { "MembershipId" });
            DropColumn("dbo.Members", "MembershipId");
            DropTable("dbo.Memberships");
        }
    }
}
