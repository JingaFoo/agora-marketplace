namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCentsAndConditionToProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Cents", c => c.Byte(nullable: false));
            AddColumn("dbo.Products", "Condition", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Condition");
            DropColumn("dbo.Products", "Cents");
        }
    }
}
