using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace village_management
{
    public partial class UserHome : Form
    {

        private string userName;
        private string userEmail;

        // Modify constructor to accept user details
        public UserHome(string userName, string userEmail)
        {
            InitializeComponent();
            this.userName = userName;
            this.userEmail = userEmail;
            lblUserName.Text = $"Welcome, {userName}!";

        }



        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserSearch obj = new UserSearch(userName, userEmail);
            obj.Show();
            this.Hide();
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

        private void UserHome_Load(object sender, EventArgs e)
        {
            // Display logged-in user information on the form


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserNotice obj = new UserNotice(userName, userEmail);
            obj.Show();
            this.Hide();
        }

        private void backmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
