using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Class.Client
{
    public class Physical
    {
        private int height;
        private int weight;
        private string injury;

        public Physical (int height, int weight, string injury)
        {
            this.height = height;
            this.weight = weight;
            this.injury = injury;
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Injury
        {
            get { return injury; }
            set { injury = value; }
        }

        //Priskiria kliento fizinius duomenis
        public void createPhysicalData(int height, int weight, string injury, string lastName)
        {
            MySqlCommand cmd = null;

            string query = "INSERT INTO `mydb`.`fiziniai_duomenys` (`ugis_cm`, `svoris_kg`, `traumos`, `kliento_id`) VALUES ('"+height+"', '"+weight+"', '"+injury+"', (SELECT kliento_id FROM klientas WHERE pavarde = '"+lastName+"'));";

            cmd = MySQLUtility.Query(query);
        }
    }
}
