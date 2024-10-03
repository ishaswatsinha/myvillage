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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace village_management
{
    public partial class UserComplaint : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        private string userName;
        private string userEmail;
        public UserComplaint(string userName, string userEmail)
        {
            InitializeComponent();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserComplaint obj = new UserComplaint(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Csubmit_Click(object sender, EventArgs e)
        {
            string query = "insert into Complaints(ComBy ,subject,description)VALUES(@Comby, @subject,@desc)";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@ComBy", "shaswat");
            cmd.Parameters.AddWithValue("@subject", subject.Text);
            cmd.Parameters.AddWithValue("@desc", description.Text);
            cmd.Parameters.AddWithValue("@Comby", userName );
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submit Successfully!!!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserComplaint_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();
            this.Hide();
        }
    }
}
