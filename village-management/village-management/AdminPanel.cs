using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
=======
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
>>>>>>> 8a3a813dc79d798b0f21512e5860d62f91cf3245

namespace village_management
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

<<<<<<< HEAD
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminPanel obj = new AdminPanel();
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminManage obj = new AdminManage();
            obj.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNotice obj = new AddNotice();
            obj.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminComplaints obj = new AdminComplaints();
            obj.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
=======
        private void label3_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Rishabh\\Documents\\Visual Studio 2022\\Projects\\myvillage\\myvillage\\village-management\\village-management\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM Users";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    label5.Text = count.ToString();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Rishabh\\Documents\\Visual Studio 2022\\Projects\\myvillage\\myvillage\\village-management\\village-management\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM Complaints";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    label5.Text = count.ToString();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Rishabh\\Documents\\Visual Studio 2022\\Projects\\myvillage\\myvillage\\village-management\\village-management\\Database1.mdf\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM Notices";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    label5.Text = count.ToString();
                }
            }
>>>>>>> 8a3a813dc79d798b0f21512e5860d62f91cf3245
        }
    }
}
