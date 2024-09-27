using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace village_management
{

    public partial class Forgot : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";

        public Forgot()
        {
            InitializeComponent();
            timer1.Start();
        }

        int countdownTime = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 60 seconds countdown
            countdownTime -= 1;
            tym.Text = Convert.ToString(countdownTime);
            Thread.Sleep(1000); // Wait for 1 second

            if (countdownTime == 0)
            {
                timer1.Stop();
                MessageBox.Show("Otp is Expired");
                string query = "DELETE FROM Token WHERE otp = otp ";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                login obj = new login();
                obj.Show();
                this.Hide();
            }

        }

        private void otpsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            string query2 = "SELECT email FROM Token WHERE otp = '" + txtotp.Text + "' ";
            SqlCommand cmd = new SqlCommand(query2, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //String email = dr["email"].ToString();
                MessageBox.Show(dr["email"].ToString());

            }

            con.Close();




        }

        private void OTP_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
