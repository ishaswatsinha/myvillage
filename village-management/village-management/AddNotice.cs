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
    public partial class AddNotice : Form
    {
        public AddNotice()
        {
            InitializeComponent();
        }

        private void NoticeSubmit_Click(object sender, EventArgs e)
        {

            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";
            string query = "insert into Notices(NoticeSubject,NoticeDesc)VALUES(@subject,@desc)";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@ComBy", "shaswat");
            cmd.Parameters.AddWithValue("@subject", NoticeSub.Text);
            cmd.Parameters.AddWithValue("@desc", NoticeDesc.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Submit Successfully!!!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
