using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCourses.Models
{
    public class CoursesDataDBContext : DbContext
    {
        public DbSet<CoursesTypes> Course { get; set; }
        public DbSet<Types> Type { get; set; }
    }
    public class CoursesTypes
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        [Display(Name ="Trainer Name")]
        public string AuthorName { get; set; }
        //[ForeignKey("TypeId")]
        public int TypeId { get; set; }
        public virtual Types Types { get; set; }
        public virtual ICollection<Types> Type { get; set; }
      
    }
    public class Types
    {
        [Key]
        public int TypeId { get; set; }
        public string CourseTypes { get; set; }
        //[ForeignKey("CourseId")]
        public int CourseId { get; set; }
        public virtual CoursesTypes CoursesTypes { get; set; }
    }


}