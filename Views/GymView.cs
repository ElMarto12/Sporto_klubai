using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporto_klubai.Views
{
    public partial class GymView : Form
    {
        public GymView()
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

        //Metodas parodo sporto klubu darbo laika
        private void show_work_time(string gymSelect)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT sav_diena AS Darbo_dienos, darbo_pradzios_laikas AS Pradzia, darbo_pabaigos_laikas AS Pabaiga FROM darbo_laikas WHERE administracijos_id = (SELECT administracijos_id FROM administracija WHERE pavadinimas = '" + gymSelect + "')";

            cmd = MySQLUtility.Query(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            workTimeData.DataSource = dt;

        }

        //Parodo sporto klubo dietologa
        private void show_worker(string gymSelect)
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT vardas, pavarde FROM dietologas WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + gymSelect + "')";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string name = dr["vardas"].ToString();
                string lastName = dr["pavarde"].ToString();

                workerSqlLabel.Text = name;
                workerLastLabel.Text = lastName;

            }

        }

        //Parodo telefono numeri sporto klubo
        private void show_phone_number(string gymSelect)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT numeris FROM telefonas WHERE administracijos_id = (SELECT administracijos_id FROM administracija WHERE pavadinimas = '"+gymSelect+"');";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string num = dr["numeris"].ToString();
             
                phoneNumberLabel.Text = num;
                
            }
        }

        //Parodo el pasta sporto klubo
        private void show_email(string gymSelect)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT adresas FROM el_pastas WHERE administracijos_id = (SELECT administracijos_id FROM administracija WHERE pavadinimas = '" + gymSelect + "');";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string email = dr["adresas"].ToString();

                emailLabel.Text = email;

            }
        }

        //Parodo sporoto klubo adresa
        private void show_address(string gymSelect)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT adresas FROM sporto_klubas WHERE pavadinimas = '"+gymSelect+"'";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string address = dr["adresas"].ToString();

                addressLabel.Text = address;

            }
        }

        //Metodas leidzia atlikti sporto klubu informacijos perziura
        private void gymList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gymList.SelectedIndex;

            string selection = gymList.Items[index].ToString();

            show_work_time(selection);
            show_worker(selection);
            show_phone_number(selection);
            show_email(selection);
            show_address(selection);
        }
    }
}
