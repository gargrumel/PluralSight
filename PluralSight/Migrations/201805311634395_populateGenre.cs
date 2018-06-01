namespace PluralSight.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Dancehall')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Reggae')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Soca')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3)");
        }
    }
}
