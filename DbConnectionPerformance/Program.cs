using EFConnection.Data;
using Microsoft.Extensions.Configuration;

string connStr = GetProviderFromConfiguration();
Console.WriteLine("Starting performance check");

var schoolContext = new SchoolContextFactory().CreateDbContext(new[] {connStr});

string GetProviderFromConfiguration()
{
    IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true, true)
    .Build();
    return config.GetConnectionString("SchoolConnectionString");
}
