namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePriceFieldToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.Byte(nullable: false));
        }
    }
}
