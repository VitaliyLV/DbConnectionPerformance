using ADOConnection;
using DapperConnection;
using DataReadLibrary;
using EFConnection.Data;
using System.Diagnostics;

namespace DbConnectionPerformance
{
    public class PerformanceTester : IPerformanceTester
    {
        private readonly Dictionary<string, IDbDataReader> dataReaders;
        private readonly Action clearCache;

        public PerformanceTester(AdoHelper ado, DapperHelper dapper, SchoolContextFactory schoolFactory)
        {
            clearCache = ado.ClearCache;
            dataReaders = new Dictionary<string, IDbDataReader>
            {
                { "ADO.NET", ado },
                { "Dapper", dapper },
                { "EF", schoolFactory.CreateDbContext(null) }
            };
        }
        public void TestReadPerformance()
        {
            Console.WriteLine("Starting performance check");
            foreach (var data in dataReaders)
            {
                clearCache();
                Stopwatch swADO = Stopwatch.StartNew();
                swADO.Start();
                data.Value.ReadStudentsFacultySubject();
                swADO.Stop();
                Console.WriteLine($"Time of {data.Key} Read for StudentsFacultySubject: {swADO.ElapsedMilliseconds}");
                Console.WriteLine();
            }
        }
    }
}
