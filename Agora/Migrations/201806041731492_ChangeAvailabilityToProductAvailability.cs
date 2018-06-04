namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAvailabilityToProductAvailability : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductAvailabilities",
                c => new
                    {
                        ProductAvailabilityId = c.Int(nullable: false, identity: true),
                        ProductAvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.ProductAvailabilityId);
            
            DropTable("dbo.Availabilities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Availabilities",
                c => new
                    {
                        AvailabilityId = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.AvailabilityId);
            
            DropTable("dbo.ProductAvailabilities");
        }
    }
}
