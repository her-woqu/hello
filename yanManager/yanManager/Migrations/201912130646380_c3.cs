namespace XireManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.XireManages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.XireManages");
        }
    }
}
