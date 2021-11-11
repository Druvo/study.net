namespace study.net.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class applicationv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Course = c.String(),
                        Contact = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
