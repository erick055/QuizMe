using LandingPage01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class SignIn : Form
    {
        private string usersFilePath = "users.txt";
        public SignIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // Assuming your textbox is txtUsername
            string password = txtPassword.Text; // Assuming your textbox is txtPassword

            // 1. Basic Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // 2. Check if user and password match
            try
            {
                if (!File.Exists(usersFilePath))
                {
                    MessageBox.Show("No users have signed up yet.");
                    return;
                }

                var lines = File.ReadAllLines(usersFilePath);
                bool loggedIn = false;

                foreach (var line in lines)
                {
                    // Split the line into parts. Format is username:password:email:fullname
                    var parts = line.Split(':');

                    // Check if the username (parts[0]) and password (parts[1]) match
                    if (parts.Length >= 2 && parts[0] == username && parts[1] == password)
                    {
                        loggedIn = true;
                        break; // Stop searching
                    }
                }

                // 3. Handle login result
                if (loggedIn)
                {
                    // SUCCESS: Open the landing page
                    LandingPage landingPage = new LandingPage();
                    landingPage.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // FAILURE: Show error
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}

