namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductAvailabilityModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductAvailabilities", "AvailabilityType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductAvailabilities", "AvailabilityType", c => c.Int(nullable: false));
        }
    }
}
