using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace TesteMirum.Data.Infra
{
    public class ConnectionFactory
    {
        public static SQLiteConnection TesteMirumDataBaseOpen()
        {
            string filename = @"TesteMirum.DataBase.db";           
            string filePath = AppDomain.CurrentDomain.BaseDirectory + filename;
            string connectionString = @"Data Source="+ filePath + "";
            var connection = new SQLiteConnection(connectionString);
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;

        }
    }
}
