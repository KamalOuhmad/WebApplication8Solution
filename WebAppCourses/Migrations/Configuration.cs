namespace WebAppCourses.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppCourses.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppCourses.Models.CoursesDataDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebAppCourses.Models.CoursesDataDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var Course1 = new CoursesTypes() { CourseId = 1 , CourseName = "JAVA", AuthorName = "Andrew Peters" };
            var Course2 = new CoursesTypes() { CourseId = 2, CourseName = ".NET", AuthorName = "Brice Lambson" };
            var Course3 = new CoursesTypes() { CourseId = 3, CourseName = "UI Developer", AuthorName = "Rowan Miller" };
            var Course4 = new CoursesTypes() { CourseId = 4, CourseName = "Database Developer", AuthorName = "Nancy Morgan" };



            context.Course.AddOrUpdate(c => c.CourseId,
                Course1,
                Course2,
                Course3,
                Course4
                );

            var Type1 = new Types() { TypeId = 1, CourseTypes = "C#" };
            var Type2 = new Types() { TypeId = 2, CourseTypes = "MVC" };
            var Type3 = new Types() { TypeId = 3, CourseTypes = "ASP.NET" };
            var Type4 = new Types() { TypeId = 4, CourseTypes = "ADO.NET" };
            var Type5 = new Types() { TypeId = 5, CourseTypes = "VB.NET" };
            var Type6 = new Types() { TypeId = 6, CourseTypes = "Core JAVA" };
            var Type7 = new Types() { TypeId = 7, CourseTypes = "Spring" };
            var Type8 = new Types() { TypeId = 8, CourseTypes = "Hibernate" };
            var Type9 = new Types() { TypeId = 9, CourseTypes = "Oracle" };
            var Type10 = new Types() { TypeId = 10, CourseTypes = "HTML" };
            var Type11 = new Types() { TypeId = 11, CourseTypes = "CSS" };
            var Type12 = new Types() { TypeId = 12, CourseTypes = "JavaScript" };
            var Type13 = new Types() { TypeId = 13, CourseTypes = "Oracle" };
            var Type14 = new Types() { TypeId = 14, CourseTypes = "MYSQL" };
            var Type15 = new Types() { TypeId = 15, CourseTypes = "SQL" };



            context.Type.AddOrUpdate(c => c.TypeId,
                Type1,
                Type2,
                Type3,
                Type4,
                Type5,
                Type6,
                Type7,
                Type8,
                Type9,
                Type10,
                Type11,
                Type12,
                Type13,
                Type14,
                Type15
                );
        }
    }
}
