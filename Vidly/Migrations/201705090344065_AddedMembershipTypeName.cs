namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMembershipTypeName : DbMigration
    {
        public override void Up()
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
            CreateIndex("dbo.MembershipTypes", "MembershipTypeName_Id");
            AddForeignKey("dbo.MembershipTypes", "MembershipTypeName_Id", "dbo.MembershipTypeNames", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MembershipTypes", "MembershipTypeName_Id", "dbo.MembershipTypeNames");
            DropIndex("dbo.MembershipTypes", new[] { "MembershipTypeName_Id" });
            DropColumn("dbo.MembershipTypes", "MembershipTypeName_Id");
            DropTable("dbo.MembershipTypeNames");
        }
    }
}
