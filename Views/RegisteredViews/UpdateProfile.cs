using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sporto_klubai.Utility;

namespace Sporto_klubai.Views.RegisteredViews
{
    public partial class UpdateProfile : Form
    {
        private string user_name;

        public string identify_name
        {
            set { user_name = value; }
        }
        public UpdateProfile()
        {
            InitializeComponent();
        }

        //atnaujina kliento el pasta
        private void update_email()
        {
            MySqlCommand cmd = null;

            string query = "UPDATE `mydb`.`asmeniniai_duomenys` SET `el_pastas` = '" + emailTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";

            cmd = MySQLUtility.Query(query);
        }

        //atnaujina kliento tel numeri
        private void update_phone()
        {
            MySqlCommand cmd = null;
            string query = "UPDATE `mydb`.`asmeniniai_duomenys` SET `tel_nr` = '" + phoneTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";
            cmd = MySQLUtility.Query(query);
        }

        //atnaujina kliento banko saskaitos numeri
        private void update_bank()
        {
            MySqlCommand cmd = null;
            string query = "UPDATE `mydb`.`asmeniniai_duomenys` SET `banko_saskaitos_nr` = '" + bankTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";
            cmd = MySQLUtility.Query(query);
        }

        //atnaujina kliento gimimo data
        private void update_date()
        {
            MySqlCommand cmd = null;
            string query = "UPDATE `mydb`.`asmeniniai_duomenys` SET `gimimo_data` = '" + dateTime.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'))";
            cmd = MySQLUtility.Query(query);
        }

        //atnaujina kliento ugi
        private void update_height()
        {
            MySqlCommand cmd = null;
            string query = "UPDATE `mydb`.`fiziniai_duomenys` SET `ugis_cm` = '" + heightTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";
            cmd = MySQLUtility.Query(query);
        }

        //atnaujina kliento svori
        private void update_weight()
        {
            MySqlCommand cmd = null;

            string query = "UPDATE `mydb`.`fiziniai_duomenys` SET `svoris_kg` = '" + weightTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";
            cmd = MySQLUtility.Query(query);
        }
        //atnaujina kliento traumas
        private void update_injury()
        {
            MySqlCommand cmd = null;
            string query = "UPDATE `mydb`.`fiziniai_duomenys` SET `traumos` = '" + injuryTxt_box.Text + "' WHERE (`kliento_id` = (SELECT kliento_id FROM klientas WHERE vardas = '" + user_name + "'));";
            cmd = MySQLUtility.Query(query);
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void updateEmail_btn_Click(object sender, EventArgs e)
        {
            update_email();
        }

        private void updatePhone_btn_Click(object sender, EventArgs e)
        {
            update_phone();
        }

        private void updateBank_btn_Click(object sender, EventArgs e)
        {
            update_bank();
        }

        private void updateDate_btn_Click(object sender, EventArgs e)
        {
            update_date();
        }

        private void updateWeightHeight_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(heightTxt_box.Text) || string.IsNullOrEmpty(weightTxt_box.Text))
            {
                MessageBox.Show("Įrašykite informaciją");
            }
            else if (!string.IsNullOrEmpty(heightTxt_box.Text) && !string.IsNullOrEmpty(weightTxt_box.Text))
            {

                update_height();
                update_weight();
            }
            else if (!string.IsNullOrEmpty(heightTxt_box.Text))
            {
                update_height();
            }
            else if (!string.IsNullOrEmpty(weightTxt_box.Text))
            {
                update_weight();
            }
        }

        private void updateInjury_btn_Click(object sender, EventArgs e)
        {
            update_injury();
        }
    }
}
