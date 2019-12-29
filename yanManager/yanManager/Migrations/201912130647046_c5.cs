namespace XireManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SideBars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SideBars");
        }
    }
}
