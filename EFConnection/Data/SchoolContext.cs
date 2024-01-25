using EFConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConnection.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(50);
        }
    }
}
