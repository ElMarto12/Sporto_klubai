using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Views.RegisteredViews
{
    public partial class Main : Form
    {
        private string user_name;

        public Main()
        {
            InitializeComponent();

        }

        public string identify_name
        {
            set { user_name = value; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = user_name;
            show_userService();
            show_pTraining();
            show_gTraining();
            show_pTrainer();
            show_gTrainer();
            show_nutritionPlan();
        }

        //Parodo klineto uzsakyta naryste
        private void show_userService()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT pavadinimas FROM naryste WHERE narystes_id = (SELECT narystes_id FROM kliento_abonementas WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string service = dr["pavadinimas"].ToString();

                serviceDataLabel.Text = service;

            }
        }

        //Parodo kliento asmenine treniruote
        private void show_pTraining()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT tipas FROM asmenine_treniruote WHERE asmen_treniruotes_id = (SELECT asmen_treniruotes_id FROM kliento_asmenine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string ptraining = dr["tipas"].ToString();

                personalTrainingData.Text = ptraining;

            }
        }

        //parodo kliento grupine treniruote
        private void show_gTraining()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT treniruotes_pavadinimas FROM grupine_treniruote WHERE grup_treniruotes_id = (SELECT grup_treniruotes_id FROM kliento_grupine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string gtraining = dr["treniruotes_pavadinimas"].ToString();

                groupTrainingData.Text = gtraining;

            }
        }

        //parodo kliento asmenini treneri
        private void show_pTrainer()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT vardas, pavarde FROM asmeninis_treneris WHERE trenerio_id = (SELECT trenerio_id FROM kliento_asmen_treneris WHERE kliento_asmenine_tren_id = (SELECT kliento_asmenine_tren_id FROM kliento_asmenine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')))";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string ptrainerN = dr["vardas"].ToString();
                string ptrainerL = dr["pavarde"].ToString();

                personalTrainerData.Text = ptrainerN + " " + ptrainerL;

            }
        }

        //parodo kliento grupines treniruotes treneri
        private void show_gTrainer()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT vardas, pavarde FROM grupiniu_treniruočių_treneris WHERE grup_trenerio_id = (SELECT grup_trenerio_id FROM kliento_grupines_treneris WHERE kliento_grup_treniruotes_id = (SELECT kliento_grup_treniruotes_id FROM kliento_grupine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')))";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string gtrainerN = dr["vardas"].ToString();
                string gtrainerL = dr["pavarde"].ToString();

                groupTrainerData.Text = gtrainerN + " " + gtrainerL;

            }
        }

        private void show_nutritionPlan()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT plano_tipas FROM kliento_mitybos_planas WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string plan = dr["plano_tipas"].ToString();

                nutritionPlanData.Text = plan;

            }
        }

        //atsaukia kliento naryste
        private void delete_service()
        {
            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_abonementas` WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";

            cmd = MySQLUtility.Query(query);
        }
        //atsaukia kliento asmenine treniruote
        private void delete_personalTraining()
        {
            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_asmenine_treniruote` WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";
            cmd = MySQLUtility.Query(query);
        }

        //atsaukia kliento asmenini treneri
        private void delete_personalTrainer()
        {
            string fullname = personalTrainerData.Text;
            string[] split = fullname.Split(' ');

            string name = " ";
            string lname = " ";

            name = split[0];
            lname = split[1];

            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_asmen_treneris` WHERE (`trenerio_id` = (SELECT trenerio_id FROM asmeninis_treneris WHERE vardas = '" + name + "' AND pavarde = '" + lname + "'))";
            cmd = MySQLUtility.Query(query);
        }
        //atsaukia kliento grupine treniruote
        private void delete_groupTraining()
        {
            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_grupine_treniruote` WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";
            cmd = MySQLUtility.Query(query);
        }
        //atsaukia kliento grupines treniruotes treneri
        private void delete_groupTrainer()
        {
            string fullname = groupTrainerData.Text;
            string[] split = fullname.Split(' ');

            string name = " ";
            string lname = " ";

            name = split[0];
            lname = split[1];

            MessageBox.Show(name + lname);

            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_grupines_treneris` WHERE (`grup_trenerio_id` = (SELECT grup_trenerio_id FROM grupiniu_treniruočių_treneris WHERE vardas = '" + name + "' AND pavarde = '" + lname + "'))";
            cmd = MySQLUtility.Query(query);
        }

        //atsaukia kliento mitybos plana
        private void delete_nutritionPlan()
        {
            MySqlCommand cmd = null;
            string query = "DELETE FROM `mydb`.`kliento_mitybos_planas` WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '"+user_name+"'))";
            cmd = MySQLUtility.Query(query);
        }

        private void cancelPersonalTraining_btn_Click(object sender, EventArgs e)
        {
            delete_personalTrainer();
            delete_personalTraining();

        }

        private void cancelService_btn_Click(object sender, EventArgs e)
        {
            delete_service();
        }

        private void cancelGroupTraining_btn_Click(object sender, EventArgs e)
        {
            delete_groupTrainer();
            delete_groupTraining();
        }

        private void cancelNutritionPlan_btn_Click(object sender, EventArgs e)
        {
            delete_nutritionPlan();
        }
    }
}
