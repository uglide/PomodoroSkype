using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace PomodoroSkype.ExternalComponents
{
    static class DbHelper
    {
        public const string DbDefaultPath = @".\data.db";

        public static SQLiteConnection Connect()
        {
            var connection = new SQLiteConnection();
            var cs = new SQLiteConnectionStringBuilder {DataSource = DbDefaultPath};
            connection.ConnectionString = cs.ToString();
            connection.Open();
            return connection;
        }

    }
}
