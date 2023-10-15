namespace oyun_sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        category_Id = c.Int(nullable: false, identity: true),
                        category_Name = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.category_Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        game_Id = c.Int(nullable: false, identity: true),
                        game_Name = c.String(nullable: false, maxLength: 30, unicode: false),
                        description = c.String(maxLength: 300, unicode: false),
                        file = c.String(maxLength: 100, unicode: false),
                        image = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.game_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_Id = c.Int(nullable: false, identity: true),
                        user_Name = c.String(nullable: false, maxLength: 40, unicode: false),
                        user_Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        user_Authorization = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Games");
            DropTable("dbo.Categories");
        }
    }
}
