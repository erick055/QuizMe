using System;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace QuizMe_
{
    public partial class SignUp : Form
    {
       
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        public SignUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) 
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                return;
            }

           
            try
            {
                
                string passwordHash = PasswordHelper.HashPassword(password);

                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                   
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sign up successful! You can now log in.");

                SignIn signInForm = new SignIn();
                signInForm.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
              
                if (ex.Number == 2627 || ex.Number == 2601) 
                {
                    MessageBox.Show("This username is already taken. Please choose another.");
                }
                else
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            this.Hide();
            signin.Show();
        }
    }
}