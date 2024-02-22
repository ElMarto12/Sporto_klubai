using Sporto_klubai.Class;
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

namespace Sporto_klubai
{
    // visur koda komentuoti
    public partial class Login : Form
    {
        private Form? activeForm;
        public Login()
        {
            InitializeComponent();
        }

        public string insert_name
        {
            get { return username_box.Text; }
        }

        public string insert_password
        {
            get { return password_box.Text; }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        // Šis metodas suteikia leidimą vartotojui prisijungti, tikrinant ar teisingas slaptažodis
        private void tryLogin_btn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(password_box.Text) || !string.IsNullOrEmpty(username_box.Text))
            {



                string username = username_box.Text;
                string password = password_box.Text;



                User aUser = DBUser.RetrieveUser(username);

                if (aUser.Password.Equals(password))
                {
                    if (aUser.Role.Equals("klientas"))
                    {
                        ClientMenu client = new ClientMenu();
                        client.identify_name = username_box.Text;
                       
                        client.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Blogas slaptažodis");
                }
            }
            else
            {
                MessageBox.Show("Vienas iš laukų yra tuščias !");
            }

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Register());
        }

        //Šis metodas sukeičia langus
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
            this.panelLogin.Controls.Add(childForm);
            this.panelLogin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
