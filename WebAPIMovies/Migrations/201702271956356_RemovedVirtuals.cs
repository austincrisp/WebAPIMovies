namespace WebAPIMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedVirtuals : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Users", "ReviewId", "dbo.Reviews");
            DropIndex("dbo.Reviews", new[] { "MovieId" });
            DropIndex("dbo.Users", new[] { "ReviewId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Users", "ReviewId");
            CreateIndex("dbo.Reviews", "MovieId");
            AddForeignKey("dbo.Users", "ReviewId", "dbo.Reviews", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
    }
}
