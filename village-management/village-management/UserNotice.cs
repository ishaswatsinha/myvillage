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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace village_management
{

    public partial class UserNotice : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        private string userName;
        private string userEmail;
        public UserNotice(string userName, string userEmail)
        {
            InitializeComponent();
            AllNotice();
            this.userName = userName;
            this.userEmail = userEmail;
            lblUserName.Text = $"Welcome, {userName}!";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserHome obj = new UserHome(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserProfile obj = new UserProfile(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserComplaint obj = new UserComplaint(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSearch obj = new UserSearch(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserNotice obj = new UserNotice(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }

        private void AllNotice()
        {
            SqlConnection con = new SqlConnection(constring);
            string query = "select*from Notices";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NoticeGrid.DataSource = dt;
            con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }
        private void opendata()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from Notices Where id='" + NoticeId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                NoticeHeading.Text = dr["NoticeSubject"].ToString();
                NoticeDesc.Text = dr["NoticeDesc"].ToString();


            }

            con.Close();
        }

        private void OpenNotice_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            opendata();
        }
    }
}
