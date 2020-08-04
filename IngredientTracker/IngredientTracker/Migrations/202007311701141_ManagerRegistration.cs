namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManagerRegistrations",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        RepeatPassword = c.String(),
                    })
                .PrimaryKey(t => t.ManagerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManagerRegistrations");
        }
    }
}
