using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sporto_klubai.Views;
using Sporto_klubai.Views.Services.Registered;
using Sporto_klubai.Views.RegisteredViews;

namespace Sporto_klubai
{
    public partial class ClientMenu : Form
    {
        private Form? activeForm;

        private string user_name;

        public string identify_name
        {
            set { user_name = value; }
        }

        public ClientMenu()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

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
            this.windowPanel.Controls.Add(childForm);
            this.windowPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void singOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void services_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "NARYSTĖS";
            ServicesLog svc = new ServicesLog();
            svc.identify_name = user_name;
            OpenChildForm(svc);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "PAGRINDINIS";
            Main main = new Main();
            string temp = user_name;
            main.identify_name = temp;
            OpenChildForm(main);
        }

        private void training_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "TRENIRUOTĖS";
            TrainingViewLog train = new TrainingViewLog();
            train.identify_name = user_name;
            OpenChildForm(train);
        }

        private void nutritionPlan_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "MITYBOS PLANAS";
            NutritionPlanViewLog nut = new NutritionPlanViewLog();
            nut.identify_name = user_name;
            OpenChildForm(nut);
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "PROFILIS";
            Profile acc = new Profile();
            acc.identify_name = user_name;
            OpenChildForm(acc);
        }
    }
}
