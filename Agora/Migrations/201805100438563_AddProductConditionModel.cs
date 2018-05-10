namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductConditionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductConditions",
                c => new
                    {
                        ConditionId = c.Int(nullable: false, identity: true),
                        ConditionType = c.String(),
                    })
                .PrimaryKey(t => t.ConditionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductConditions");
        }
    }
}
