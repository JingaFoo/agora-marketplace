namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubcategoriesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        SubcategoryId = c.Int(nullable: false, identity: true),
                        SubcategoryName = c.String(),
                    })
                .PrimaryKey(t => t.SubcategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subcategories");
        }
    }
}
