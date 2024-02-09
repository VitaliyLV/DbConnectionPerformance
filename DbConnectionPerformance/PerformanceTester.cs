using ADOConnection;
using DataReadLibrary;
using System.Diagnostics;

namespace DbConnectionPerformance
{
    public class PerformanceTester
    {
        private readonly Dictionary<string, IDbDataReader> dataReaders;
        private readonly Action clearCache;

        public PerformanceTester(Dictionary<string, IDbDataReader> dataReaders, Action clearCache)
        {
            this.dataReaders = dataReaders;
            this.clearCache = clearCache;
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
