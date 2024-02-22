using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Class
{
    public class User
    {
        private string username;
        private string password;
        private string role;

        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public String UserName { get { return username; } set { username = value; } }
        public String Password { get { return password; } set { password = value; } }
        public String Role { get { return role; } set { role = value; } }

        //Metodas, kuris sukuria naują vartotoją sistemoje, atsisžvelgiant į rolę
        public void createUser(string username, string password, string role) 
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `mydb`.`vartotojas` (`vartotojo_vardas`, `slaptazodis`, `tipas`) VALUES ('" + username + "', '" + password + "', '" + role + "');";


            cmd = MySQLUtility.Query(query);
        }
    }

}
