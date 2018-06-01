namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropProductAvailabilityTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Availability");
            DropTable("dbo.ProductAvailabilities");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Availability");
            DropTable("dbo.ProductAvailabilities");
        }
    }
}
