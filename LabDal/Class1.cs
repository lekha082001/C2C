using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabDal
{
    public class Student
    {
        [Key]
        public int StudentKey { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public  bool IsActive { get; set; }
    }
    public class Company : Student
    {
        [NotMapped]
        public string CompanyName { get; set;}
    }
    public class Course : Student
    {
        [NotMapped]
        public string CourseName { get; set; }

    }
    public class Student1
    {
        [Key]
        public int StudentKey { get; set;}
        public string StudentName { get; set; }
    }
    public class ToCourses
    {
        [Key]
        public string CourseName { get; set; }
    }
    public class Course1
    {
        [Key]
        public int CourseKey { get; set; }
    }
    public class ToManyStuds
    {
        [Key]
        public int StudentKey { get; set; }
        public string StudentName { get; set; }
    }
    public class LabDbContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Course> Coureses { get; set; }
        public DbSet<Student1> Student1s { get; set; }
        public DbSet<ToCourses> ToCoursess { get; set; }
        public DbSet<Course1> Course1s { get; set; }
        public DbSet<ToManyStuds> ToManyStudss { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=LabDb;Trusted_Connection=true");
        }
    }
}