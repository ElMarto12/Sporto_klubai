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

namespace Sporto_klubai.Views
{
    public partial class NutritionPlanView : Form
    {
        public NutritionPlanView()
        {
            InitializeComponent();
            insert_listbox();
        }

        //Parodo visus dietologus
        private void insert_listbox()
        {

            MySqlCommand cmd = null;
            DataTable dt;
            MySqlDataAdapter sda;

            workerList.Items.Clear();

            string query = "SELECT * FROM mydb.dietologas";
            cmd = MySQLUtility.Query(query);
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    string worker_name = dr["vardas"].ToString();
                    string last_name = dr["pavarde"].ToString();
                    workerList.Items.Add(worker_name + " " + last_name);

                }
            }

        }

        //Parodo mitybos plana pagal dietologo varda ir pavarde
        private void show_nutrition_plan(string name, string lastname)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT pavadinimas FROM mitybos_planas WHERE dietologo_id = (SELECT dietologo_id FROM dietologas WHERE vardas = '"+name+"' AND pavarde = '"+lastname+"');";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string plan = dr["pavadinimas"].ToString();
              
                nutritionPlanDBlabel.Text = plan;

            }
        }

        //Parodo pradzia ir pabaiga mitybos plano datas
        private void show_plan_date(string name, string lastname)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT pradzios_data, pabaigos_data FROM mitybos_planas WHERE dietologo_id = (SELECT dietologo_id FROM dietologas WHERE vardas = '"+name+"' AND pavarde = '"+lastname+"');";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string begin = dr["pradzios_data"].ToString();
                string end = dr["pabaigos_data"].ToString();

                beginDBlabel.Text = begin;
                endDBlabel.Text = end;

            }
        }
    
        //Parodo mitybos plano kaina
        private void show_price(string name, string lastname)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT kaina FROM mitybos_planas WHERE dietologo_id = (SELECT dietologo_id FROM dietologas WHERE vardas = '"+name+"' AND pavarde = '"+lastname+"');";

            dt = new DataTable();
            cmd = MySQLUtility.Query(query);
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string price = dr["kaina"].ToString();

                priceDBlabel.Text = price;

            }
        }

        //Parodo mitybos plano patiekalus
        private void show_food(string nutPlan)
        {
            MySqlCommand cmd = null;
            MySqlDataAdapter sda;
            DataTable dt;

            string query = "SELECT pavadinimas AS Patiekalas FROM patiekalas WHERE patiekalo_id = (SELECT patiekalo_id FROM plano_patiekalas WHERE mitybos_plano_id = (SELECT mitybos_plano_id FROM mitybos_planas WHERE pavadinimas = '"+nutPlan+"'));";

            cmd = MySQLUtility.Query(query);

            dt = new DataTable();
            sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);

            foodData.DataSource = dt;
        }
        private void workerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = workerList.SelectedIndex;
            string name = "";
            string lastname = "";

            string selection = workerList.Items[index].ToString();
            string[] split = selection.Split(' ');

            name = split[0];
            lastname = split[1];

            show_nutrition_plan(name, lastname);    
            show_plan_date(name, lastname);
            show_price(name, lastname); 
            show_food(nutritionPlanDBlabel.Text);
        }
    }
}
