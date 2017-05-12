namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAvailableCopiesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableCopies", c => c.Int(nullable: false));

            Sql("UPDATE Movies SET AvailableCopies = MovieStockCount");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AvailableCopies");
        }
    }
}
