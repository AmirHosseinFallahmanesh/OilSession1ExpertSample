namespace School.Infrastrucure.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        Name = c.String(),
                        SurName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
