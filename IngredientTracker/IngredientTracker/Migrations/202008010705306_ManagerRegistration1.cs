namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerRegistration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ManagerRegistrations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ManagerRegistrations", "Phone", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.ManagerRegistrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ManagerRegistrations", "Password", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.ManagerRegistrations", "RepeatPassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ManagerRegistrations", "RepeatPassword", c => c.String());
            AlterColumn("dbo.ManagerRegistrations", "Password", c => c.String());
            AlterColumn("dbo.ManagerRegistrations", "Email", c => c.String());
            AlterColumn("dbo.ManagerRegistrations", "Phone", c => c.String());
            AlterColumn("dbo.ManagerRegistrations", "Name", c => c.String());
        }
    }
}
