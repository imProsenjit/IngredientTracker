namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chef : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        ChefId = c.Int(nullable: false, identity: true),
                        ChefUserName = c.String(nullable: false),
                        ChefPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ChefId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chefs");
        }
    }
}
