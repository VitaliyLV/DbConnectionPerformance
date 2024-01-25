using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EFConnection.Data
{
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            //IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", true, true).Build();
            //var connStr = config.GetConnectionString("SchoolConnectionString");
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            optionsBuilder.UseSqlServer(connStr);
            return new SchoolContext(optionsBuilder.Options);
        }
    }
}
