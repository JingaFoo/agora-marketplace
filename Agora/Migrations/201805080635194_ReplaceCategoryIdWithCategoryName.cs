namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReplaceCategoryIdWithCategoryName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryName", c => c.String());
            DropColumn("dbo.Products", "CategoriesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoriesId", c => c.Byte(nullable: false));
            DropColumn("dbo.Products", "CategoryName");
        }
    }
}
