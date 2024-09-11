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

               
            }
            else
            {
                // Incorrect credentials: Show error message
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateLogin(string email, string password)
        {
            // Connect to the database and check for matching credentials

            using (SqlConnection connection = new SqlConnection(constring))
            {
                try
                {
                    connection.Open();

                    // SQL query to check if the user exists with the provided email and password
                    string query = "SELECT COUNT(1) FROM register WHERE email = @Email AND password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
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
    }
}
