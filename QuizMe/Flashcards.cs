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
   
    public partial class Flashcards : Form
    {
        SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;");

        private List<Flashcard> allFlashcards = new List<Flashcard>();
        private int currentCardIndex = 0;

        private DateTime? _filterDate = null;

        public Flashcards()
        {


            InitializeComponent();

        }
        public Flashcards(DateTime filterDate)
        {
            InitializeComponent();
            _filterDate = filterDate.Date; // Store the date
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();

            settings.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();

            progress.Show();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();


            schedule.Show();
        }

        private void btnQui_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            this.Hide();

            quizzes.Show();
        }

        private void btnFla_Click(object sender, EventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard = new Dashboard2();
            this.Hide();

            dashboard.Show();
        }

        private void createFlashcardButton_Click(object sender, EventArgs e)
        {
            CreateFlashcard createFlashcard = new CreateFlashcard();
            this.Hide();

            createFlashcard.Show();
        }



        private void button11_Click(object sender, EventArgs e)
        {

            lblAnswer.Text = "";
        }

        private void lblSeeAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Visible = true;
            lblSeeAnswer.Visible = false;
        }

        private void Flashcards_Load(object sender, EventArgs e)
        {
            DeleteExpiredFlashcards(); 
            LoadFlashcardsFromDB();    
            DisplayCurrentCard();
        }
        private void LoadFlashcardsFromDB()
        {
            allFlashcards.Clear();
            try
            {
                con.Open();

                string query = "SELECT question, answer, schedule_date FROM Flashcards WHERE user_id = @user_id";

                // --- MODIFIED LOGIC ---
                // We CAST schedule_date to a DATE to compare it with our date-only filter
                if (_filterDate.HasValue)
                {
                    query += " AND CAST(schedule_date AS DATE) = @schedule_date_filter";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", QuizMe_.SignIn.staticUserID);

                    if (_filterDate.HasValue)
                    {
                        // The parameter name is changed to avoid clashes
                        cmd.Parameters.AddWithValue("@schedule_date_filter", _filterDate.Value);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allFlashcards.Add(new Flashcard
                            {
                                Question = reader["question"].ToString(),
                                Answer = reader["answer"].ToString(),
                                ScheduleDate = reader["schedule_date"] == DBNull.Value
                                               ? (DateTime?)null
                                               : Convert.ToDateTime(reader["schedule_date"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading flashcards: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
        private void DeleteExpiredFlashcards()
        {
            // We use a NEW connection here to keep it separate and safe
            using (SqlConnection deleteCon = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;"))
            {
                try
                {
                    deleteCon.Open();
                    // This query deletes cards for this user that are in the past
                    string query = "DELETE FROM Flashcards WHERE user_id = @user_id AND schedule_date < @current_datetime";

                    using (SqlCommand cmd = new SqlCommand(query, deleteCon))
                    {
                        cmd.Parameters.AddWithValue("@user_id", QuizMe_.SignIn.staticUserID);
                        cmd.Parameters.AddWithValue("@current_datetime", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // If it fails, just log it. Don't stop the form from loading.
                    Console.WriteLine("Error deleting expired cards: " + ex.Message);
                }
            } // The 'using' block automatically closes the connection
        }
        private void DisplayCurrentCard()
        {
            if (allFlashcards.Count > 0)
            {
                Flashcard currentCard = allFlashcards[currentCardIndex];
                lblQuestion.Text = currentCard.Question;
                lblAnswer.Text = currentCard.Answer;
                lblAnswer.Visible = false;
                lblSeeAnswer.Visible = true;
                lblCardNo.Text = $"card {currentCardIndex + 1} of {allFlashcards.Count}";

                // --- MODIFIED LOGIC ---
                if (currentCard.ScheduleDate.HasValue)
                {
                    // Format the time to "hh:mm tt" (e.g., "02:30 PM")
                    string timeString = currentCard.ScheduleDate.Value.ToString("hh:mm tt");
                    lblScheduledIdentifier.Text = $"📅 Scheduled for {timeString}";
                    lblScheduledIdentifier.Visible = true;
                }
                else
                {
                    lblScheduledIdentifier.Visible = false;
                }
                // --- END OF MODIFIED LOGIC ---
            }
            else
            {
                if (_filterDate.HasValue)
                {
                    lblQuestion.Text = "No flashcards scheduled for this day.";
                }
                else
                {
                    lblQuestion.Text = "No flashcards found.";
                }

                lblAnswer.Text = "";
                lblAnswer.Visible = false;
                lblSeeAnswer.Visible = false;
                lblCardNo.Text = "card 0 of 0";
                lblScheduledIdentifier.Visible = false; // Also hide it here
            }
        }
       
        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (allFlashcards.Count > 0 && currentCardIndex < allFlashcards.Count - 1)
            {
                currentCardIndex++;
                DisplayCurrentCard();
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentCardIndex > 0)
            {
                currentCardIndex--;
                DisplayCurrentCard();
            }
        }
        public class Flashcard
        {
            public string Question { get; set; }
            public string Answer { get; set; }
            public DateTime? ScheduleDate { get; set; }
        }
    }
}
