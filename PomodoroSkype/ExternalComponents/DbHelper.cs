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

        private static SQLiteConnection db = null;

        public static SQLiteConnection Connect()
        {
            var connection = new SQLiteConnection();
            var cs = new SQLiteConnectionStringBuilder {DataSource = DbDefaultPath};
            connection.ConnectionString = cs.ToString();
            connection.Open();
            return connection;
        }

        public static SQLiteDataReader Select(string querySelect)
        {
            if (null == db)
            {
                db = Connect();
            }

            SQLiteCommand query = db.CreateCommand();
            query.CommandText = querySelect;

            return query.ExecuteReader();            
        }

        public static void CloseConnection()
        {
            if (null != db)
            {
                db.Close();
            }
        }
    }
}
