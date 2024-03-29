﻿using DataReadLibrary;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace ADOConnection
{
    public class AdoHelper : IDbDataReader
    {
        private readonly string? connectionStr;
        private readonly IQueryHelper helper;

        public AdoHelper(IQueryHelper helper)
        {
            connectionStr = helper.GetProviderFromConfiguration();
            this.helper = helper;
        }

        public void ReadStudentsFacultySubject()
        {
            string query = helper.StudentFacultyRead;
            using (DbConnection connection = SqlClientFactory.Instance.CreateConnection())
            {
                connection.ConnectionString = connectionStr;
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

        public void ClearCache()
        {
            using (DbConnection connection = SqlClientFactory.Instance.CreateConnection())
            {
                connection.ConnectionString = connectionStr;
                connection.Open();
                DbCommand command = SqlClientFactory.Instance.CreateCommand();
                command.Connection = connection;
                command.CommandText = "DBCC FREEPROCCACHE";
                command.ExecuteReader();
            }
        }
    }
}
