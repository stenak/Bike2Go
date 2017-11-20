namespace Bike2Go.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "MembershipTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Members", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Members", "MembershipType_Id");
            AddForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Members", new[] { "MembershipType_Id" });
            DropColumn("dbo.Members", "MembershipType_Id");
            DropColumn("dbo.Members", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
