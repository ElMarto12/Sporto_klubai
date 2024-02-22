using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporto_klubai.Views.RegisteredViews
{
    public partial class TrainingViewLog : Form
    {
        private bool personalButtonStatus = false;
        private bool groupButtonStatus = false;
        private string selection;
        private string tselection;
        private string trselection;
        private string user_name;
        private string tname;
        private string tlastname;

        public TrainingViewLog()
        {
            InitializeComponent();
            insert_listbox();
        }

        public string Tname
        {
            set { tname = value; }
        }

        public string Tlastname
        {
            set { tlastname = value; }
        }

        public string identify_name
        {
            set { user_name = value; }
        }

        //Parodo visus sporto klubus
        private void insert_listbox()
        {

            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            gymList.Items.Clear();

            string query = "SELECT * FROM mydb.sporto_klubas";
            cmd = MySQLUtility.Query(query);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string gym_name = dr["pavadinimas"].ToString();
                    gymList.Items.Add(gym_name);

                }
            }

        }

        //Atvaizduoja grupines arba asmenines treniruotes
        private void show_training(string selection)
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            if (personalButtonStatus)
            {
                trainingList.Items.Clear();

                string query = "SELECT tipas FROM asmenine_treniruote WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + selection + "')";
                cmd = MySQLUtility.Query(query);
                if (cmd != null)
                {
                    dt = new DataTable();
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string training = dr["tipas"].ToString();
                        trainingList.Items.Add(training);

                    }
                }

            }
            else if (groupButtonStatus)
            {
                trainingList.Items.Clear();

                string query = "SELECT treniruotes_pavadinimas FROM grupine_treniruote WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + selection + "')";
                cmd = MySQLUtility.Query(query);
                if (cmd != null)
                {
                    dt = new DataTable();
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string training = dr["treniruotes_pavadinimas"].ToString();
                        trainingList.Items.Add(training);

                    }
                }
            }

        }

        //Parodo trenerius asmeninius ir grupiniu treniruociu
        private void show_treners()
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            if (personalButtonStatus)
            {
                trenerList.Items.Clear();

                string query = "SELECT * FROM asmeninis_treneris;";
                cmd = MySQLUtility.Query(query);
                if (cmd != null)
                {
                    dt = new DataTable();
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string name = dr["vardas"].ToString();
                        string lastname = dr["pavarde"].ToString();
                        trenerList.Items.Add(name + " " + lastname);

                    }
                }

            }
            else if (groupButtonStatus)
            {
                trenerList.Items.Clear();

                string query = "SELECT * FROM grupiniu_treniruočių_treneris;";
                cmd = MySQLUtility.Query(query);
                if (cmd != null)
                {
                    dt = new DataTable();
                    sda = new MySqlDataAdapter(cmd);
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        string name = dr["vardas"].ToString();
                        string lastname = dr["pavarde"].ToString();
                        trenerList.Items.Add(name + " " + lastname);
                    }
                }
            }
        }

        private void gymList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gymList.SelectedIndex;

            selection = gymList.Items[index].ToString();

        }

        private void trainingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trainingList.SelectedIndex;

            tselection = trainingList.Items[index].ToString();
        }

        private void personalTraining_btn_Click_1(object sender, EventArgs e)
        {
            personalButtonStatus = true;
            groupButtonStatus = false;

            show_training(selection);
            show_treners();
        }

        private void groupTraining_btn_Click_1(object sender, EventArgs e)
        {
            personalButtonStatus = false;
            groupButtonStatus = true;

            show_training(selection);
            show_treners();
        }

        //priskiria klientui asmenine treniruote
        private void add_pTraining()
        {
            MySqlCommand cmd = null;
            string query = "INSERT INTO `mydb`.`kliento_asmenine_treniruote` (`asmen_treniruotes_id`, `kliento_id`) VALUES ((SELECT asmen_treniruotes_id FROM asmenine_treniruote WHERE tipas = '" + tselection + "'), (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";
            cmd = MySQLUtility.Query(query);

        }

        //priskiria klientui grupine treniruote
        private void add_gTraining()
        {
            MySqlCommand cmd = null;
            string query = "INSERT INTO `mydb`.`kliento_grupine_treniruote` (`grup_treniruotes_id`, `kliento_id`) VALUES ((SELECT grup_treniruotes_id FROM grupine_treniruote WHERE treniruotes_pavadinimas = '" + tselection + "'),(SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";
            cmd = MySQLUtility.Query(query);

        }

        //priskiria klientui asmenini treneri
        private void add_pTrainer()
        {
            MySqlCommand cmd = null;
            string query = "INSERT INTO `mydb`.`kliento_asmen_treneris` (`kliento_asmenine_tren_id`, `trenerio_id`) VALUES ((SELECT kliento_asmenine_tren_id FROM kliento_asmenine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '"+user_name+"')), (SELECT trenerio_id FROM asmeninis_treneris WHERE vardas = '"+tname +"' AND pavarde = '"+tlastname +"'))";

            cmd = MySQLUtility.Query(query);
        }

        //priskiria klientui grupiniu treniruoiu treneri
        private void add_gTrainer()
        {
            MySqlCommand cmd = null;
            string query = "INSERT INTO `mydb`.`kliento_grupines_treneris` (`grup_trenerio_id`, `kliento_grup_treniruotes_id`) VALUES ((SELECT grup_trenerio_id FROM grupiniu_treniruočių_treneris WHERE vardas = '"+tname +"' AND pavarde = '"+tlastname+"'), (SELECT kliento_grup_treniruotes_id FROM kliento_grupine_treniruote WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '"+user_name+"')))";
            cmd = MySQLUtility.Query(query);
        }

        private void trenerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = trenerList.SelectedIndex;
            
            trselection = trenerList.Items[index].ToString();
            string[] split = trselection.Split(' ');

            tname = split[0];
            tlastname = split[1];
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (personalButtonStatus)
            {
                add_pTraining();
                add_pTrainer();
            }
            else if (groupButtonStatus)
            {
                add_gTraining();
                add_gTrainer();
            }
        }

       
    }
}
