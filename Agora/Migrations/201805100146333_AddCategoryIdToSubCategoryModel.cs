namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryIdToSubCategoryModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subcategories", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subcategories", "CategoryId");
        }
    }
}
