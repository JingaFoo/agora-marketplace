namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdToProductId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "Id");
            AddColumn("dbo.Products", "ProductId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductId");
            AddPrimaryKey("dbo.Products", "Id");
        }
    }
}
