using DataReadLibrary;
using EFConnection.Configurations;
using EFConnection.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EFConnection.Data
{
    public class SchoolContext : DbContext, IDbDataReader
    {
        public SchoolContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentMark> StudentMarks { get; set; }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new MarkConfiguration());
        }

        public void ReadStudentsFacultySubject()
        {
            var result = Students.Include(s => s.InFaculty).Include(s => s.Marks)
                .Select(s => new
                {
                    fname = s.FirstName,
                    lname = s.LastName,
                    fc = s.InFaculty.Name,
                    mk = s.Marks.Sum(n => n.TotalScore)
                });
            foreach (var s in result)
            {
                Console.WriteLine($"{s.fname, -10} {s.lname, 10} {s.fc, 15} {s.mk, 5}");
            }
        }
    }
}
