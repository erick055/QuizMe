using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class CreateQuizForm : Form
    {
       
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        
        public bool QuizCreatedSuccessfully { get; private set; } = false;
        public int NewQuizID { get; private set; } 

        public CreateQuizForm()
        {
            InitializeComponent();
        }

       
        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSaveQuiz_Click_1(object sender, EventArgs e)
        {
            string title = txtQuizTitle.Text.Trim();
            string description = txtQuizDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title for the quiz.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    string query = @"INSERT INTO Quizzes (UserID, Title, Description, CreatedDate, ScheduledDate) 
                                     VALUES (@UserID, @Title, @Description, @CreatedDate, @ScheduledDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", QuizMe_.SignIn.staticUserID);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                        
                        if (chkEnableSchedule.Checked)
                        {
                            
                            cmd.Parameters.AddWithValue("@ScheduledDate", dtpScheduledDate.Value);
                        }
                        else
                        {
                            
                            cmd.Parameters.AddWithValue("@ScheduledDate", DBNull.Value);
                        }
                    

                        cmd.ExecuteNonQuery();
                        QuizCreatedSuccessfully = true;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                QuizCreatedSuccessfully = false; 
                MessageBox.Show("Error creating quiz: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void CreateQuizForm_Load(object sender, EventArgs e)
        {
            
            chkEnableSchedule.Checked = false;

            dtpScheduledDate.Enabled = false;
        }

  
        private void chkEnableSchedule_CheckedChanged(object sender, EventArgs e)
        {
            dtpScheduledDate.Enabled = chkEnableSchedule.Checked;
        }
    }
}