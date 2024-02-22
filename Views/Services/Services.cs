using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporto_klubai.Views.Services.Unregistered;

namespace Sporto_klubai.Views.Services
{
    public partial class Services : Form
    {
        private Form? activeForm;
        public Services()
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
            this.servicePanel.Controls.Add(childForm);
            this.servicePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void serviceBasic_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Basic());
        }

        private void serviceAmatuer_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Amatuer());
        }

        private void serviceAllInclusive_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllInclusive());
        }
    }
}
