using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Class.Client
{
    public class Client
    {
        private string name;
        private string lastName;

        public Client(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public void createClient(string name, string lastName, string pass)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `mydb`.`klientas` (`vardas`, `pavarde`, `vartotojo_id`) VALUES ('"+name+"', '"+lastName+"', (SELECT vartotojo_id FROM vartotojas WHERE slaptazodis = '"+pass+"'));";

            cmd = MySQLUtility.Query(query);
        }
    }
}
