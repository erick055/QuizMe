using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace QuizMe_
{
    public partial class Quizzes : Form
    {
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        public Quizzes()
        {
            InitializeComponent();
        }
        private void Quizzes_Load(object sender, EventArgs e)
        {
            DeleteExpiredScheduledQuizzes();
            LoadAvailableQuizzes();
            LoadRecentActivities();
            CheckForScheduledQuizzes();
        }
        private void CheckForScheduledQuizzes()
        {
            int dueQuizzes = 0;

            
            string query = @"SELECT COUNT(*) 
                             FROM Quizzes 
                             WHERE UserID = @UserID 
                               AND ScheduledDate IS NOT NULL 
                               AND ScheduledDate <= @due_time";

            
            DateTime dueTime = DateTime.Now.AddMinutes(5);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);

                        
                        cmd.Parameters.AddWithValue("@due_time", dueTime);

                        con.Open();
                        dueQuizzes = (int)cmd.ExecuteScalar();
                    }
                }

                if (dueQuizzes > 0)
                {
                    
                    MessageBox.Show($"You have {dueQuizzes} quiz(zes) scheduled to take in the next 5 minutes!",
                                    "Quiz Reminder",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Optional: Show an error if the check fails
                // MessageBox.Show("Error checking for scheduled quizzes: " + ex.Message);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            this.Hide();
            settings.Show();
        }

       

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();
            schedule.Show();
        }

        private void glossaryButton_Click(object sender, EventArgs e)
        {
            GlossaryForm glossaryForm = new GlossaryForm();
            this.Hide();
            glossaryForm.Show();
        }

        private void quizzesButton_Click(object sender, EventArgs e)
        {

        }

        private void flashcardsButton_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();
            this.Hide();

            flashcards.Show();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            this.Hide();

            dashboard2.Show();
        }

        private void createQuizzButton_Click(object sender, EventArgs e)
        {
            CreateQuizForm createForm = new CreateQuizForm();
            createForm.ShowDialog();

            if (createForm.QuizCreatedSuccessfully)
            {

                LoadAvailableQuizzes();


            }
        }


        private void LoadAvailableQuizzes()
        {
            flpAvailableQuizzes.Controls.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string query = "SELECT QuizID, Title, Description, ScheduledDate FROM Quizzes WHERE UserID = @UserID ORDER BY CreatedDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int currentQuizID = (int)reader["QuizID"];

                            
                            object scheduledDateObj = reader["ScheduledDate"];

                           
                            Panel quizPanel = new Panel();

                            
                            quizPanel.Size = new Size(flpAvailableQuizzes.Width - 25, 120);
                            quizPanel.BorderStyle = BorderStyle.FixedSingle;
                            quizPanel.Margin = new Padding(5);

                           
                            Label titleLabel = new Label();
                            titleLabel.Text = reader["Title"].ToString();
                            titleLabel.Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold);
                            titleLabel.Location = new Point(10, 10);
                            titleLabel.AutoSize = true;

                            Label descLabel = new Label();
                            descLabel.Text = reader["Description"].ToString();
                            descLabel.Location = new Point(10, 35);
                            descLabel.Size = new Size(quizPanel.Width - 150, 35);
                            descLabel.AutoSize = false;

                            
                            Label scheduleLabel = new Label();
                            scheduleLabel.Location = new Point(10, 75); 
                            scheduleLabel.AutoSize = true;
                            scheduleLabel.Font = new Font(this.Font.FontFamily, 9, FontStyle.Italic);

                            if (scheduledDateObj == DBNull.Value)
                            {
                                scheduleLabel.Text = "Not scheduled";
                                scheduleLabel.ForeColor = Color.Gray;
                            }
                            else
                            {
                                DateTime scheduledDate = (DateTime)scheduledDateObj;
                                
                                scheduleLabel.Text = $"Scheduled: {scheduledDate.ToString("g")}";
                                scheduleLabel.ForeColor = Color.DarkGreen;
                            }
                            
                            Button btnAddQuestions = new Button();
                            btnAddQuestions.Text = "Add Questions";
                            btnAddQuestions.Location = new Point(quizPanel.Width - 110, 8);
                            btnAddQuestions.Tag = currentQuizID;
                            btnAddQuestions.Click += new EventHandler(btnAddQuestions_Click);

                            
                            Button btnStartQuiz = new Button();
                            btnStartQuiz.Text = "Start";
                            btnStartQuiz.Location = new Point(quizPanel.Width - 110, 38);
                            btnStartQuiz.Tag = currentQuizID;
                            btnStartQuiz.Click += new EventHandler(btnStartQuiz_Click);

                            
                            Button btnDeleteQuiz = new Button();
                            btnDeleteQuiz.Text = "Delete";
                            btnDeleteQuiz.BackColor = Color.LightCoral;
                            btnDeleteQuiz.Location = new Point(quizPanel.Width - 110, 68);
                            btnDeleteQuiz.Tag = currentQuizID;
                            btnDeleteQuiz.Click += new EventHandler(btnDeleteQuiz_Click);

                            
                            quizPanel.Controls.Add(titleLabel);
                            quizPanel.Controls.Add(descLabel);
                            quizPanel.Controls.Add(scheduleLabel); 
                            quizPanel.Controls.Add(btnAddQuestions);
                            quizPanel.Controls.Add(btnStartQuiz);
                            quizPanel.Controls.Add(btnDeleteQuiz);

                            
                            flpAvailableQuizzes.Controls.Add(quizPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quizzes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadRecentActivities()
        {
            
            List<Label> scoreLabels = new List<Label> {lblRecentScore1, lblRecentScore2, lblRecentScore3};

            
            foreach (Label lbl in scoreLabels)
            {
                lbl.Text = ""; 
                lbl.Visible = false;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    
                    string query = @"SELECT TOP 3 Q.Title, R.Score, R.TotalQuestions
                                     FROM QuizResults AS R
                                     JOIN Quizzes AS Q ON R.QuizID = Q.QuizID
                                     WHERE R.UserID = @UserID
                                     ORDER BY R.DateTaken DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        int index = 0;
                        while (reader.Read() && index < 3)
                        {
                            string title = reader["Title"].ToString();
                            string score = $"{reader["Score"]}/{reader["TotalQuestions"]}";

                            
                            Label currentLabel = scoreLabels[index];
                            currentLabel.Text = $"{title} - Score: {score}";
                            currentLabel.Visible = true;

                            index++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recent activities: " + ex.Message);
            }
        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int quizID = (int)clickedButton.Tag;

            AddQuestionsForm addForm = new AddQuestionsForm(quizID);
            addForm.ShowDialog();

            LoadAvailableQuizzes(); 
        }

        
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int quizID = (int)clickedButton.Tag;

            
            QuizTakerForm quizForm = new QuizTakerForm(quizID);
            quizForm.ShowDialog();
            
        }

        
        private void btnDeleteQuiz_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int quizID = (int)clickedButton.Tag;

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this quiz?\nAll of its questions will be permanently removed.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        
                        string query = "DELETE FROM Quizzes WHERE QuizID = @QuizID AND UserID = @UserID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@QuizID", quizID);
                            cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    
                    LoadAvailableQuizzes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting quiz: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            StudySets studySets = new StudySets();
            this.Hide();
            studySets.Show();
        }

        private void DeleteExpiredScheduledQuizzes()
        {
            
            using (SqlConnection deleteCon = new SqlConnection(connectionString))
            {
                try
                {
                    deleteCon.Open();
                    
                    string query = @"DELETE FROM Quizzes 
                                     WHERE UserID = @UserID 
                                     AND ScheduledDate IS NOT NULL 
                                     AND ScheduledDate < GETDATE()";

                    using (SqlCommand cmd = new SqlCommand(query, deleteCon))
                    {
                        cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("Error deleting expired scheduled quizzes: " + ex.Message);
                }
            }
        }
    }
}
