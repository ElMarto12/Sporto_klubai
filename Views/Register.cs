using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporto_klubai.Views;

namespace Sporto_klubai
{
    public partial class Register : Form
    {
        private Form? activeForm;

        public Register()
        {
            InitializeComponent();
        }

        public string insert_name
        {
            get { return nameTxt_box.Text; } 
        }

        public string insert_lastName
        {
            get { return lastNameTxt_box.Text;}
        }

        public string insert_pass
        {
            get { return passwordTxt_box.Text; }
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
            this.panelRegister.Controls.Add(childForm);
            this.panelRegister.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void continue1_btn_Click(object sender, EventArgs e)
        {   
            PersonalData ps = new PersonalData();

            ps.identify_name = nameTxt_box.Text;
            ps.identify_lastName = lastNameTxt_box.Text;
            ps.identify_password = passwordTxt_box.Text;

            OpenChildForm(ps);

        }
    }
}
