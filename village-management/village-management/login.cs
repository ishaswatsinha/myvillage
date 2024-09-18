using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace village_management
{
    public partial class login : Form
    {
        string gender = "";
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shasw\Desktop\netproject\village-management\village-management\VILLAGE-MANAGEMENT.mdf;Integrated Security=True";
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel7.BringToFront();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.BringToFront();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.BringToFront();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.BringToFront();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel5.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4.BringToFront();
        }



        //  -----------------------REGISTRATION PAGE--------------------------------
        //  -----------------------REGISTRATION PAGE--------------------------------
        //  -----------------------REGISTRATION PAGE--------------------------------

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "insert into register(name,email,hno,uid, phone, password,gender)VALUES(@name,@email,@house,@uid,@phone,@password,@gender)";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@house", textBox5.Text);
            cmd.Parameters.AddWithValue("@uid", textBox6.Text);
            cmd.Parameters.AddWithValue("@phone", textBox7.Text);
            cmd.Parameters.AddWithValue("@password", textBox9.Text);
            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully!!!");
            panel2.BringToFront();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //  -----------------------LOGIN PAGE--------------------------------
        //  -----------------------LOGIN PAGE--------------------------------
        //  -----------------------LOGIN PAGE--------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Validate credentials with the database
            if (ValidateLogin(email, password))
            {
                // Correct credentials: Show the next form
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserHome obj = new UserHome();
                obj.Show();
                this.Hide();


            }
            else
            {
                // Incorrect credentials: Show error message
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function for Validate User

        private bool ValidateLogin(string email, string password)
        {
            // Connect to the database and check for matching credentials

            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();

                    // SQL query to check if the user exists with the provided email and password
                    string query2 = "SELECT COUNT(1) FROM register WHERE email = @Email AND password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query2, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        // If count is 1, the user exists with the correct credentials
                        return count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        //  -----------------------FORGOT PAGE--------------------------------
        //  -----------------------FORGOT PAGE--------------------------------
        //  -----------------------FORGOT PAGE--------------------------------


        // --------MAIL SENT-----------------
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Random random = new Random();
                int otp = random.Next(100000, 1000000);


                SmtpClient Smtp_Server = new SmtpClient();
                MailMessage e_mail = new MailMessage();
                Smtp_Server.UseDefaultCredentials = false;
                Smtp_Server.Port = 587;
                Smtp_Server.EnableSsl = true;
                Smtp_Server.Host = "smtp.gmail.com";
                Smtp_Server.Credentials =
            new System.Net.NetworkCredential("hackathonrku@gmail.com", "vwhd bsfm glbo neyn");
                e_mail = new MailMessage();
                e_mail.From = new MailAddress("hackathonrku@gmail.com");
                e_mail.To.Add(txtTo.Text);
                e_mail.Subject = "Email Sending";
                e_mail.IsBodyHtml = false;
                e_mail.Body = Convert.ToString(otp);
                Smtp_Server.Send(e_mail);
                string query3 = "insert into Token(email,otp)VALUES(@email,@otp)";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(query3, con);

                cmd.Parameters.AddWithValue("@email", txtTo.Text);
                cmd.Parameters.AddWithValue("@otp", otp);

                cmd.ExecuteNonQuery();



                con.Close();
                // MessageBox.Show("Mail Sent");
                Forgot obj = new Forgot();
                obj.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in Mail Sent");
            }
        }


        //ADMIN LOGIN
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
