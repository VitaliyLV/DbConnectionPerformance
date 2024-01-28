using EFConnection.Data;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

string connStr = GetProviderFromConfiguration();
Console.WriteLine("Starting performance check");

//EF
var schoolContext = new SchoolContextFactory().CreateDbContext(null);
Stopwatch swEF = Stopwatch.StartNew();
swEF.Start();
schoolContext.ReadStudentsFacultySubject();
swEF.Stop();
Console.WriteLine($"Time of EF Read for StudentsFacultySubject: {swEF.ElapsedMilliseconds}");

string GetProviderFromConfiguration()
{
    IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true, true)
    .Build();
    return config.GetConnectionString("SchoolConnectionString");
}
