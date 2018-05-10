namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubCategoryToProductsModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SubCategoryName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "SubCategoryName");
        }
    }
}
