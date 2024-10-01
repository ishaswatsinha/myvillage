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
    public partial class AdminManage : Form
    {
        public AdminManage()
        {
            InitializeComponent();
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
    }
}
