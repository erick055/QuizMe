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

namespace QuizMe_
{
    public partial class CreateFlashcard : Form
    {
        SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;");
        public CreateFlashcard()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();

            this.Hide();

            flashcards.Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtQuestion.Text) || string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please enter both a question and an answer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                // UPDATED QUERY: Added the schedule_date column
                string query = "INSERT INTO Flashcards (user_id, question, answer, schedule_date) VALUES (@user_id, @question, @answer, @schedule_date)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", QuizMe_.SignIn.staticUserID);
                    cmd.Parameters.AddWithValue("@question", txtQuestion.Text);
                    cmd.Parameters.AddWithValue("@answer", txtAnswer.Text);

                    // --- NEW LINE ---
                    // Get the date value from the DateTimePicker
                    // Save the exact date and time selected in the picker
                    cmd.Parameters.AddWithValue("@schedule_date", dtpScheduleDate.Value);
                    // --- END OF NEW LINE ---

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Flashcard saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form to loop back for new input
                txtQuestion.Clear();
                txtAnswer.Clear();
                dtpScheduleDate.Value = DateTime.Now; // Reset picker
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
