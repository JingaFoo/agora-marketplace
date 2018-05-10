namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Product", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Products", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Products", "Product");
        }
    }
}
