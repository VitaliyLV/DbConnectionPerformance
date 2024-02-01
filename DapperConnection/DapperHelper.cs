using Dapper;
using System.Data.SqlClient;

namespace DapperConnection
{
    public class DapperHelper
    {
        public static void ReadStudentsFacultySubject(string connectionString, string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var students = connection.Query(query);
                foreach (var student in students)
                {
                    if (student != null)
                        Console.WriteLine($"{student.fname,-10} {student.lname,10} {student.fc,15} {student.mk,5}");
                }

            }
        }
    }
}
