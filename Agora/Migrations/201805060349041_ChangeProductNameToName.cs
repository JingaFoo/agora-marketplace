namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProductNameToName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "ProductName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ProductName", c => c.String());
            DropColumn("dbo.Products", "Name");
        }
    }
}
