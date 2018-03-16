namespace EF6_CodeFirst_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertDataIntoVideosAndGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1,'Comedy'),(2,'Horror'),(3,'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
