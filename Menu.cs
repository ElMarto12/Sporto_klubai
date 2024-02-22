using Sporto_klubai.Utility;
using MySql.Data;
using MySql.Data.MySqlClient;
using Sporto_klubai.Views;
using Sporto_klubai.Views.Services;
using System.Runtime.InteropServices;

namespace Sporto_klubai
{
    public partial class Menu : Form
    {
        private Form? activeForm;
        public Menu()
        {
            InitializeComponent();
            MySQLUtility.MakeConnection();
            OpenChildForm(new MainView());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void home_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "PAGRINDINIS";
            OpenChildForm(new MainView());

        }

        private void gymList_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "SPORTO KLUBAI";
            OpenChildForm(new GymView());
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "INVENTORIUS";
            OpenChildForm(new InventoryView());

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
            this.panelWindow.Controls.Add(childForm);
            this.panelWindow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "KLIENTO PRISIJUNGIMAS";
            OpenChildForm(new Login());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void services_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "NARYSTĖS";
            OpenChildForm(new Services());
        }

        private void training_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "TRENIRUOTĖS";
            OpenChildForm(new TrainingView());
        }

        private void nutritionPlan_btn_Click(object sender, EventArgs e)
        {
            windowName.Text = "MITYBOS PLANAI";
            OpenChildForm(new NutritionPlanView());
        }
    }
}