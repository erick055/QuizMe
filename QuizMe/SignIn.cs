using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Added this

namespace QuizMe_
{
    public partial class SignIn : Form
    {
        // Connection string (must be the same as in SignUp)
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        public SignIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // --- Database Logic ---
            try
            {
                string storedHash = null;

                // 1. Create connection and command
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 2. Add parameter
                        cmd.Parameters.AddWithValue("@Username", username);

                        // 3. Execute and get the stored hash
                        var result = cmd.ExecuteScalar(); // Gets the first column of the first row
                        if (result != null)
                        {
                            storedHash = result.ToString();
                        }
                    }
                }

                // 4. Verify login
                if (storedHash != null && PasswordHelper.VerifyPassword(password, storedHash))
                {
                    // SUCCESS: Open the landing page
                    Dashboard2 dashboard = new Dashboard2();
                    dashboard.Show();
                    this.Hide();
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