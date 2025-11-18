using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class StudySets : Form
    {
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";

        public StudySets()
        {
            InitializeComponent();
        }

        private void btnAddNewSet_Click(object sender, EventArgs e)
        {
            UploadStudySetForm uploadForm = new UploadStudySetForm();
            uploadForm.ShowDialog();

            if (uploadForm.IsUploadSuccessful)
            {

                LoadStudySets();
            }
        }

        private void StudySets_Load(object sender, EventArgs e)
        {
            LoadStudySets();
        }
        private void LoadStudySets()
        {
            flpStudySets.Controls.Clear();
            string query = "SELECT StudySetID, Title, Subject, Progress FROM StudySets WHERE UserID = @UserID";

            
            int currentUserID = QuizMe_.SignIn.staticUserID;

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", currentUserID);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Panel setPanel = new Panel();
                        setPanel.Size = new Size(flpStudySets.Width - 25, 100);
                        setPanel.BorderStyle = BorderStyle.FixedSingle;

                        Label titleLabel = new Label();
                        titleLabel.Text = reader["Title"].ToString();
                        titleLabel.Location = new Point(10, 10);
                        titleLabel.Font = new Font(titleLabel.Font, FontStyle.Bold);
                        titleLabel.AutoSize = true;

                        Label subjectLabel = new Label();
                        subjectLabel.Text = "Subject: " + reader["Subject"].ToString();
                        subjectLabel.Location = new Point(10, 35);
                        subjectLabel.AutoSize = true;

                        ProgressBar progressBar = new ProgressBar();
                        progressBar.Value = (int)reader["Progress"];
                        progressBar.Location = new Point(10, 65);
                        progressBar.Size = new Size(150, 20);

                        Button openButton = new Button();
                        openButton.Text = "Open PDF";
                        openButton.Location = new Point(180, 62);
                        openButton.Tag = reader["StudySetID"];
                        openButton.Click += OpenButton_Click;

                        
                        Button studyButton = new Button();
                        studyButton.Text = "Study Flashcards";
                        studyButton.Location = new Point(270, 62);
                        studyButton.Tag = reader["StudySetID"]; 
                        studyButton.Click += StudyButton_Click; 
                                                                

                        Button deleteButton = new Button();
                        deleteButton.Text = "Delete";
                        deleteButton.BackColor = Color.LightCoral;
                        deleteButton.Location = new Point(380, 62); 
                        deleteButton.Tag = reader["StudySetID"];
                        deleteButton.Click += DeleteButton_Click;

                        setPanel.Controls.Add(titleLabel);
                        setPanel.Controls.Add(subjectLabel);
                        setPanel.Controls.Add(progressBar);
                        setPanel.Controls.Add(openButton);
                        setPanel.Controls.Add(studyButton); 
                        setPanel.Controls.Add(deleteButton);

                        flpStudySets.Controls.Add(setPanel);
                    }
                }
            }
        }
        private void StudyButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int studySetID = (int)clickedButton.Tag;

            
            Flashcards flashcardForm = new Flashcards(studySetID);
            this.Hide();
            flashcardForm.Show();
            
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int studySetID = (int)clickedButton.Tag;

            OpenPdfViewer(studySetID);
        }
        private void OpenPdfViewer(int studySetID)
        {
            byte[] pdfData;

            
            string query = "SELECT PdfData FROM StudySets WHERE StudySetID = @StudySetID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudySetID", studySetID);
                    con.Open();
                    pdfData = (byte[])cmd.ExecuteScalar();
                }
            }

            if (pdfData != null)
            {
                
                PdfViewForm viewForm = new PdfViewForm(pdfData);
                viewForm.Show();
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int studySetID = (int)clickedButton.Tag;
            int currentUserID = QuizMe_.SignIn.staticUserID; 

            
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this study set?\n\n",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        
                        string queryUpdateFlashcards = "UPDATE Flashcards SET StudySetID = NULL WHERE StudySetID = @StudySetID AND user_id = @UserID";
                        using (SqlCommand cmdUpdate = new SqlCommand(queryUpdateFlashcards, con))
                        {
                            cmdUpdate.Parameters.AddWithValue("@StudySetID", studySetID);
                            cmdUpdate.Parameters.AddWithValue("@UserID", currentUserID);
                            cmdUpdate.ExecuteNonQuery();
                        }

                        
                        string queryDeleteSet = "DELETE FROM StudySets WHERE StudySetID = @StudySetID AND UserID = @UserID";
                        using (SqlCommand cmdDelete = new SqlCommand(queryDeleteSet, con))
                        {
                            cmdDelete.Parameters.AddWithValue("@StudySetID", studySetID);
                            cmdDelete.Parameters.AddWithValue("@UserID", currentUserID);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }

                    
                    LoadStudySets();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting study set: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
           
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
            Flashcards flashcards = new Flashcards();
            this.Hide();
            flashcards.Show();
        }

        private void btnGlo_Click(object sender, EventArgs e)
        {
            GlossaryForm glossaryForm = new GlossaryForm();
            this.Hide();
            glossaryForm.Show();
        }
    }
}
