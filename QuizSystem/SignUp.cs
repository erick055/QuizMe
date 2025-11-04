using QuizMe_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandingPage01
{
    public partial class SignUp : Form
    {
        private string usersFilePath = "users.txt";
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                return;
            }
            try
            {
                if (!File.Exists(usersFilePath))
                {
                    File.Create(usersFilePath).Close();
                }

                var lines = File.ReadAllLines(usersFilePath);

               
                
                if (lines.Any(line => line.Split(':')[0] == username))
                {
                    MessageBox.Show("This username is already taken. Please choose another.");
                    return;
                }

                
                using (StreamWriter sw = File.AppendText(usersFilePath))
                {
                    sw.WriteLine($"{username}:{password}");
                }

                MessageBox.Show("Sign up successful! You can now log in.");

                
                SignIn signInForm = new SignIn();
                signInForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}

