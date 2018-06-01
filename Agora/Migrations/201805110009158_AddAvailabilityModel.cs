namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailabilityModel : DbMigration
    {
        public override void Up()
        {

        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductAvailabilities",
                c => new
                    {
                        AvailabilityId = c.Int(nullable: false, identity: true),
                        AvailabilityType = c.String(),
                    })
                .PrimaryKey(t => t.AvailabilityId);
            
            AddColumn("dbo.Products", "Availability", c => c.String());
        }
    }
}
