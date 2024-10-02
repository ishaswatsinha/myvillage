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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace village_management
{
    public partial class AdminManage : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        public AdminManage()
        {
            InitializeComponent();
            AllUser();
        }

        private void AdminManage_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void OpenUserDetails_Click(object sender, EventArgs e)
        {
            UserDetailPanel2.BringToFront();
            opendata();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            UpdatePanel3.BringToFront();
        }

        private void AllUser()
        {
            SqlConnection con = new SqlConnection(constring);
            string query = "select * from register";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AllUserGrid.DataSource = dt;
            con.Close();
        }
        private void opendata()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from register Where uid='" + UserId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblUserId.Text = dr["uid"].ToString();
                lblEmail.Text = dr["email"].ToString();
                lblGender.Text = dr["gender"].ToString();
                lblHouse.Text = dr["hno"].ToString();
                lblPhone.Text = dr["phone"].ToString();
                lblName.Text = dr["name"].ToString();
            }
            con.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            ViewUserPanel1.BringToFront();
        }

        private void Backbtn2_Click(object sender, EventArgs e)
        {
            UserDetailPanel2.BringToFront();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string query = "delete * from register Where uid=@Uid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Uid", txtuid.Text);
                con.Close();
                MessageBox.Show("User Deleted Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete USer ");
            }
        }

       
    }
}
