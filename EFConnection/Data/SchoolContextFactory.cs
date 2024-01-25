using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EFConnection.Data
{
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            optionsBuilder.UseSqlServer(connStr);
            return new SchoolContext(optionsBuilder.Options);
        }
    }
}
