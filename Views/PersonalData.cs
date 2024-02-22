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
using Sporto_klubai.Class;
using Sporto_klubai.Class.Client;

namespace Sporto_klubai.Views
{
    public partial class PersonalData : Form
    {
        private Form? activeForm;
        public string user_name;
        public string last_name;
        public string password;

        public PersonalData()
        {
            InitializeComponent();
        }

        public string identify_name
        {
            set { user_name = value; }
        }

        public string identify_lastName
        {
            set { last_name = value; }
        }

        public string identify_password
        {
            set { password = value; }
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
            this.panelPersonalData.Controls.Add(childForm);
            this.panelPersonalData.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelPersonalData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Register());
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string gender;

            if (maleRadio.Checked)
            {
                gender = maleRadio.Text;
            }
            else
            {
                gender = womenRadio.Text;
            }

            //Sukūria naują vartotoją
            User user = new User(user_name, password, "klientas");
            user.createUser(user.UserName, user.Password, user.Role);

            //Sukūria naują klientą
            Client client = new Client(user_name, last_name);
            client.createClient(client.Name, client.LastName, password);

            //Priskiria asmeninius duomenis klientui
            Personal ps = new Personal(phoneTxt_box.Text, emailTxt_box.Text, gender, dateTime.Text, bankTxt_box.Text, pCodeTxt_box.Text);
            ps.createPersonalData(ps.PhoneNumber, ps.Email, ps.Gender, ps.BirthDate, ps.BankNumber, ps.PersonalCode, last_name);

            //Priskiria fizinius duomenis klientui
            Physical phys = new Physical(Int32.Parse(heightTxt_box.Text), Int32.Parse(weightTxt_box.Text), injuryTxt_box.Text);
            phys.createPhysicalData(phys.Height, phys.Weight, phys.Injury, last_name);

        }
    }
}
