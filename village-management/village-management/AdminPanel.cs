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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace village_management
{
    public partial class AdminPanel : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        public AdminPanel()
        {
            InitializeComponent();
            NoticeCount();
            Residence();
            ResolvedComplaints();
        }

        private void dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


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
        }

        private void Residence()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM register";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    lblResident.Text = count.ToString();
                }
            }
        }
        private void ResolvedComplaints()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM Complaints";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    lblResolvedComp.Text = count.ToString();
                }
            }
        }
        private void NoticeCount()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "SELECT COUNT(Id) FROM Notices";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result);
                    lblNoticeCount.Text = count.ToString();
                }
            }
        }

    }
}
