namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (1, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (2, 'Adventure')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (3, 'Crime')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (4, 'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (5, 'Documentary')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (6, 'Drama')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (7, 'Fantasy')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (8, 'Historical')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (9, 'Horror')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (10, 'Musical')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (11, 'Romance')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (12, 'Sci-Fi')");
            Sql("INSERT INTO MovieGenres (Id, Genre) VALUES (13, 'War')");
        }
        
        public override void Down()
        {
        }
    }
}
