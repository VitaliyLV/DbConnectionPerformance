using ADOConnection;
using DapperConnection;
using DbConnectionPerformance;
using EFConnection.Data;
using System.Diagnostics;

string connStr = QueryHelper.GetProviderFromConfiguration();
Console.WriteLine("Starting performance check");

AdoHelper.ClearCache(connStr);
//ADO
Stopwatch swADO = Stopwatch.StartNew();
swADO.Start();
AdoHelper.ReadStudentsFacultySubject(connStr, QueryHelper.StudentFacultyRead);
swADO.Stop();
Console.WriteLine($"Time of ADO.NET Read for StudentsFacultySubject: {swADO.ElapsedMilliseconds}");
Console.WriteLine();
AdoHelper.ClearCache(connStr);

//EF
var schoolContext = new SchoolContextFactory().CreateDbContext(null);
Stopwatch swEF = Stopwatch.StartNew();
swEF.Start();
schoolContext.ReadStudentsFacultySubject();
swEF.Stop();
Console.WriteLine($"Time of EF Read for StudentsFacultySubject: {swEF.ElapsedMilliseconds}");
Console.WriteLine();

AdoHelper.ClearCache(connStr);
//Dapper
Stopwatch swDapper = Stopwatch.StartNew();
swDapper.Start();
DapperHelper.ReadStudentsFacultySubject(connStr, QueryHelper.StudentFacultyRead);
swDapper.Stop();
Console.WriteLine($"Time of Dapper Read for StudentsFacultySubject: {swDapper.ElapsedMilliseconds}");
