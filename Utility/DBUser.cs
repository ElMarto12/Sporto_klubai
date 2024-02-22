using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sporto_klubai.Class;

namespace Sporto_klubai.Utility
{
    public static class DBUser
    {
        private static MySqlCommand? cmd;
        private static DataTable? dt;
        private static MySqlDataAdapter? sda;
        public static User RetrieveUser(string username)
        {
            string query = "SELECT * FROM mydb.vartotojas where vartotojo_vardas = (@username) limit 1";
            cmd = MySQLUtility.RunQuery(query, username);
            User aUser = null;

            if(cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    string Uname = dr["vartotojo_vardas"].ToString();
                    string pass = dr["slaptazodis"].ToString();
                    string type = dr["tipas"].ToString();
                    aUser = new User(Uname, pass, type);
                }
            }

            return aUser;
        }
    }
}
