namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryIconToCategoryModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryIcon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryIcon");
        }
    }
}
