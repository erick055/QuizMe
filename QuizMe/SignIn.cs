using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizMe_ // Your namespace from the file
{
    public partial class SignIn : Form
    {
        // Connection string from your file
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        // >>> ADDED THIS <<<
        // Static variable to hold the logged-in user's ID
        public static int staticUserID;

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

            try
            {
                string storedHash = null;
                int foundUserID = 0; // >>> ADDED THIS <<<

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Query to get BOTH hash and UserId
                    string query = "SELECT PasswordHash, UserId FROM Users WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        // Use a DataReader to get both results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                storedHash = reader["PasswordHash"].ToString();
                                foundUserID = Convert.ToInt32(reader["UserId"]); // >>> ADDED THIS <<<
                            }
                        }
                    }
                } // Connection closes here

                // Verify login
                if (storedHash != null && PasswordHelper.VerifyPassword(password, storedHash))
                {
                    // SUCCESS:

                    // >>> ADDED THIS <<<
                    // Store the ID for other forms to use
                    staticUserID = foundUserID;

                    // Open the landing page
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