using ADOConnection;
using DapperConnection;
using DataReadLibrary;
using DbConnectionPerformance;
using EFConnection.Data;

string connStr = QueryHelper.GetProviderFromConfiguration();
var ado = new AdoHelper(connStr);
Action clearCache = ado.ClearCache;
Dictionary<string, IDbDataReader> list = new Dictionary<string, IDbDataReader>
{
    { "ADO.NET", ado },
    { "Dapper", new DapperHelper(connStr) },
    { "EF", new SchoolContextFactory().CreateDbContext(null) }
};

var perfTester = new PerformanceTester(list, clearCache);
perfTester.TestReadPerformance();
