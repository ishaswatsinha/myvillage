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

namespace village_management
{
    public partial class UserSearch : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";
        private string userName;
        private string userEmail;
        public UserSearch(string userName, string userEmail)
        {
            InitializeComponent();
            this.userName = userName;
            this.userEmail = userEmail;
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserNotice obj = new UserNotice(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSearch obj = new UserSearch(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void SearchPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void fetchdata()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "select * from Register Where uid='" + textId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lblName.Text = dr["name"].ToString();
                lblEmail.Text = dr["email"].ToString();
                lblPhone.Text = dr["phone"].ToString();
                lblHouse.Text = dr["hno"].ToString();
                lblGender.Text = dr["gender"].ToString();

            }

            con.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            fetchdata();
        }
    }
}
