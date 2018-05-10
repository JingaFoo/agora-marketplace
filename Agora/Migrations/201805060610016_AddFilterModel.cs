namespace Agora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilterModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filters",
                c => new
                    {
                        FilterId = c.Int(nullable: false, identity: true),
                        FilterName = c.String(),
                        FilterDescription = c.String(),
                    })
                .PrimaryKey(t => t.FilterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Filters");
        }
    }
}
