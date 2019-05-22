namespace WebAppCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoursesTypes",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        AuthorName = c.String(),
                        TypeId = c.Int(nullable: false),
                        Types_TypeId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Types", t => t.Types_TypeId)
                .Index(t => t.Types_TypeId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        CourseTypes = c.String(),
                        CourseId = c.Int(nullable: false),
                        CoursesTypes_CourseId = c.Int(),
                        CoursesTypes_CourseId1 = c.Int(),
                    })
                .PrimaryKey(t => t.TypeId)
                .ForeignKey("dbo.CoursesTypes", t => t.CoursesTypes_CourseId)
                .ForeignKey("dbo.CoursesTypes", t => t.CoursesTypes_CourseId1)
                .Index(t => t.CoursesTypes_CourseId)
                .Index(t => t.CoursesTypes_CourseId1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoursesTypes", "Types_TypeId", "dbo.Types");
            DropForeignKey("dbo.Types", "CoursesTypes_CourseId1", "dbo.CoursesTypes");
            DropForeignKey("dbo.Types", "CoursesTypes_CourseId", "dbo.CoursesTypes");
            DropIndex("dbo.Types", new[] { "CoursesTypes_CourseId1" });
            DropIndex("dbo.Types", new[] { "CoursesTypes_CourseId" });
            DropIndex("dbo.CoursesTypes", new[] { "Types_TypeId" });
            DropTable("dbo.Types");
            DropTable("dbo.CoursesTypes");
        }
    }
}
