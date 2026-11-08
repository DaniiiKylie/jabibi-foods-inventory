using System;
using System.Data.OleDb;
using System.IO;

namespace mabalot_try
{
    public static class Database
    {
        // The app runs from bin\Debug\ (or bin\Release\); jabibi.accdb sits two folders up, in the project folder.
        public static readonly string DbPath =
            Path.GetFullPath(
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\jabibi.accdb"
                )
            );

        private static readonly string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DbPath + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }
    }
}
