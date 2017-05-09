namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeName1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MembershipTypes", "MembershipTypeName_Id", "dbo.MembershipTypeNames");
            DropIndex("dbo.MembershipTypes", new[] { "MembershipTypeName_Id" });
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String());
            DropColumn("dbo.MembershipTypes", "MembershipTypeName_Id");
            DropTable("dbo.MembershipTypeNames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypeNames",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MembershipName = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MembershipTypes", "MembershipTypeName_Id", c => c.Byte());
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
            CreateIndex("dbo.MembershipTypes", "MembershipTypeName_Id");
            AddForeignKey("dbo.MembershipTypes", "MembershipTypeName_Id", "dbo.MembershipTypeNames", "Id");
        }
    }
}
