using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sporto_klubai.Utility
{
    public static class MySQLUtility
    {
        private static MySqlConnection? connection;
        private static MySqlCommand? cmd;
        // private static DataTable dt;
        // private static MySqlDataAdapter sda;
        private static string? myConnectionString;


        public static void MakeConnection()
        {
            
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.UserID = "root";
                builder.Password = "admin";
                builder.Database = "mydb";
                builder.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(builder.ToString());

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public static MySqlCommand RunQuery(string query, string username)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }

            return cmd;
        }

        public static MySqlCommand Query(string query)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
                connection.Close();
            }

            return cmd;
        }
    }
}
