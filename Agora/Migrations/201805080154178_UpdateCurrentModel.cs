namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCurrentModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoriesId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CategoriesId");
        }
    }
}
