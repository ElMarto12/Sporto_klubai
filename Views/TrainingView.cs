using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporto_klubai.Views
{
    public partial class TrainingView : Form
    {
        private bool personalButtonStatus = false;
        private bool groupButtonStatus = false;
        private string selection;
        
        public TrainingView()
        {
            InitializeComponent();
            insert_listbox();

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
                string query = "SELECT tipas AS Treniruotė FROM asmenine_treniruote WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + selection + "');";

                cmd = MySQLUtility.Query(query);

                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                trainingData.DataSource = dt;
            }
            else if (groupButtonStatus)
            {
                string query = "SELECT treniruotes_pavadinimas AS Treniruotė, max_dalyviu_skaicius AS `Maksimalus Dalyvių Skaičius` FROM grupine_treniruote WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + selection + "')";

                cmd = MySQLUtility.Query(query);

                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                trainingData.DataSource = dt;
            }

        }

        private void gymList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gymList.SelectedIndex;

            selection = gymList.Items[index].ToString();

        }

        private void personalTraining_btn_Click(object sender, EventArgs e)
        {
            personalButtonStatus = true;
            groupButtonStatus = false;

            show_training(selection);
        }

        private void groupTraining_btn_Click(object sender, EventArgs e)
        {
            personalButtonStatus = false;
            groupButtonStatus = true;

            show_training(selection);
        }

        private void trainingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trainingLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
