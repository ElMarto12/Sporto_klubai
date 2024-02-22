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
using MySql.Data.MySqlClient;

namespace Sporto_klubai.Views
{
    public partial class InventoryView : Form
    {
        public InventoryView()
        {
            InitializeComponent();
            insert_listbox();

        }

        //Parodo visus sporto klubus
        private void insert_listbox()
        {

            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            gymList.Items.Clear();

            string query = "SELECT * FROM mydb.sporto_klubas";
            cmd = MySQLUtility.Query(query);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string gym_name = dr["pavadinimas"].ToString();
                    gymList.Items.Add(gym_name);

                }
            }

        }

        private void show_inventory(string gymSelect)
        {
            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            string query = "SELECT pavadinimas AS Pavadinimas FROM sporto_irankis WHERE viso_inventoriaus_id = (SELECT viso_inventoriaus_id FROM sporto_klubo_inventorius WHERE sporto_klubo_id = (SELECT sporto_klubo_id FROM sporto_klubas WHERE pavadinimas = '" + gymSelect + "'));";

            cmd = MySQLUtility.Query(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            inventoryData.DataSource = dt;
        }

        private void gymList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gymList.SelectedIndex;

            string select = gymList.Items[index].ToString();

            show_inventory(select);
        }
    }
}
