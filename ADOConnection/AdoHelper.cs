using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace ADOConnection
{
    public class AdoHelper
    {
        public static void ReadStudentsFacultySubject(string connectionString, string query)
        {
            using (DbConnection connection = SqlClientFactory.Instance.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = SqlClientFactory.Instance.CreateCommand();
                command.Connection = connection;
                command.CommandText = query;
                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["fname"],-10} {dataReader["lname"],10} {dataReader["fc"],15} {dataReader["mk"],5}");
                    }
                }
            }
        }

        public static void ClearCache(string connectionString)
        {
            using (DbConnection connection = SqlClientFactory.Instance.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DbCommand command = SqlClientFactory.Instance.CreateCommand();
                command.Connection = connection;
                command.CommandText = "DBCC FREEPROCCACHE";
                command.ExecuteReader();
            }
        }
    }
}
