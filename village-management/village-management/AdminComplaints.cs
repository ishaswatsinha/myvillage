using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace village_management
{

    public partial class AdminComplaints : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        public AdminComplaints()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(constring);
            string query = "select*from Complaints";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            allcomplaints.DataSource = dt;
            con.Close();

        }

        private void opendata()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from Complaints Where id='" + ComId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Cheading.Text = dr["subject"].ToString();
                CDesc.Text = dr["description"].ToString();


            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ComOpen_Click(object sender, EventArgs e)
        {
            Com2.BringToFront();
            opendata();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Com1.BringToFront();
        }
    }
}
