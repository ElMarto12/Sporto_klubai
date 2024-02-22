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

namespace Sporto_klubai.Views.Services.Unregistered
{
    public partial class Amatuer : Form
    {
        private Form? activeForm;
        public Amatuer()
        {
            InitializeComponent();
            show_services();
            show_price();
            show_duration();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.durationDBlabel.Controls.Add(childForm);
            this.durationDBlabel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Parodo narystes paslaugas
        private void show_services()
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            string query = "SELECT paslaugos_pavadinimas AS Paslauga FROM narystes_paslauga WHERE narystes_id = 2";

            cmd = MySQLUtility.Query(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            servicesData.DataSource = dt;
        }

        //Parodo narystes laikotarpi
        private void show_duration()
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT trukme_men FROM naryste WHERE narystes_id = 2;";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string time = dr["trukme_men"].ToString();

                duration.Text = time;

            }
        }

        private void show_price()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT menesine_kaina FROM naryste WHERE narystes_id = 2;";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string price = dr["menesine_kaina"].ToString();

                priceDBlabel.Text = price;

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Services());
        }
    }
}
