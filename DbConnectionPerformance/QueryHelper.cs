using Microsoft.Extensions.Configuration;

namespace DbConnectionPerformance
{
    public static class QueryHelper
    {
        public static string StudentFacultyRead = "SELECT [s].[FirstName] AS [fname], [s].[LastName] AS [lname], [f].[Name] AS [fc], " +
           "(SELECT COALESCE(SUM([s0].[TotalScore]), 0) FROM [StudentMarks] AS [s0] " +
           " WHERE [s].[Id] = [s0].[StudentId]) AS [mk] FROM [Students] AS [s] INNER JOIN [Faculties] AS [f] " +
           "ON [s].[InFacultyId] = [f].[Id]";
        public static string GetProviderFromConfiguration()
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            return config.GetConnectionString("SchoolConnectionString");
        }
    }
}
