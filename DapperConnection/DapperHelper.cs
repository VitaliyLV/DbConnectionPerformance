﻿using Dapper;
using DataReadLibrary;
using System.Data.SqlClient;

namespace DapperConnection
{
    public class DapperHelper: IDbDataReader
    {
        private readonly string? connectionStr;
        private readonly IQueryHelper helper;

        public DapperHelper(IQueryHelper helper)
        {
            this.connectionStr = helper.GetProviderFromConfiguration();
            this.helper = helper;
        }
        public void ReadStudentsFacultySubject()
        {
            string query = helper.StudentFacultyRead;
            using (var connection = new SqlConnection(connectionStr))
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
