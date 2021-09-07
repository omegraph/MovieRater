namespace MovieRater.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TVShow",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        ParentalGuidance = c.String(nullable: false),
                        Genre = c.String(nullable: false),
                        Rating = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                        MainCharacters = c.String(nullable: false),
                        Seasons = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TVShow");
        }
    }
}
