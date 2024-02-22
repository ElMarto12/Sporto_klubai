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
using System.Xml.Linq;

namespace Sporto_klubai.Views.RegisteredViews
{
    public partial class Profile : Form
    {
        private Form? activeForm;
        private string user_name;

        public string identify_name
        {
            set { user_name = value; }
        }

        public Profile()
        {
            InitializeComponent();
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
            this.panelProfile.Controls.Add(childForm);
            this.panelProfile.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //parodo kliento varda ir pavarde
        private void show_nameAndLastName()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT vardas, pavarde FROM klientas WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string name = dr["vardas"].ToString();
                string lname = dr["pavarde"].ToString();

                nameData.Text = name;
                lastNameData.Text = lname;

            }
        }

        //parodo kliento fizinius duomenis
        private void show_physicalData()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT ugis_cm, svoris_kg, traumos FROM fiziniai_duomenys WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string height = dr["ugis_cm"].ToString();
                string weight = dr["svoris_kg"].ToString();
                string injury = dr["traumos"].ToString();

                heightData.Text = height;
                weightData.Text = weight;
                injuryData.Text = injury;

            }
        }

        //parodo kliento asmeninius duomenis
        private void show_personalData()
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT tel_nr, el_pastas, lytis, gimimo_data, banko_saskaitos_nr, asmens_kodas FROM asmeniniai_duomenys WHERE kliento_id = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "')";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string phone = dr["tel_nr"].ToString();
                string email = dr["el_pastas"].ToString();
                string gender = dr["lytis"].ToString();
                string birth = dr["gimimo_data"].ToString();
                string bank = dr["banko_saskaitos_nr"].ToString();
                string pCode = dr["asmens_kodas"].ToString();

                phoneData.Text = phone;
                emailData.Text = email;
                genderData.Text = gender;
                birthDateData.Text = birth;
                bankData.Text = bank;
                pCodeData.Text = pCode;
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            show_nameAndLastName();
            show_physicalData();
            show_personalData();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            UpdateProfile upd = new UpdateProfile();
            upd.identify_name = user_name;
            OpenChildForm(upd);
        }
    }
}
