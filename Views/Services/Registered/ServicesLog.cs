using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporto_klubai.Views.Services.Registered
{
    public partial class ServicesLog : Form
    {
        private Form? activeForm;
        private string user_name;
        public ServicesLog()
        {
            InitializeComponent();
        }

        public string identify_name
        {
            set { user_name = value; }
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
            BASICLog bsc = new BASICLog();
            bsc.identify_name = user_name;
            OpenChildForm(bsc);
        }

        private void serviceAmatuer_btn_Click(object sender, EventArgs e)
        {
            AMATUERLog amatuer = new AMATUERLog();
            amatuer.identify_name = user_name;
            OpenChildForm(amatuer);

        }

        private void serviceAllInclusive_btn_Click(object sender, EventArgs e)
        {
            ALLINCLUSIVELog all = new ALLINCLUSIVELog();
            all.identify_name = user_name;
            OpenChildForm(all);
        }
    }
}
