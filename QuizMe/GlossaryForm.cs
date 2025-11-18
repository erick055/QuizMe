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
    public partial class GlossaryForm : Form
    {
        private readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;";
        private DataTable glossaryTable;
        private BindingSource bindingSource;
        private string placeholderText = "Search Terminology...";

        public GlossaryForm()
        {
            InitializeComponent();
        }

        private void GlossaryForm_Load(object sender, EventArgs e)
        {
            LoadGlossaryData();
            SetupSearchPlaceholder();
        }

        private void LoadGlossaryData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    
                    string query = "SELECT Terminology, Definition FROM Glossary";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    glossaryTable = new DataTable();
                    adapter.Fill(glossaryTable);

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = glossaryTable;

                    dgvGlossary.DataSource = bindingSource;

                    
                    if (dgvGlossary.Columns["Terminology"] != null)
                    {
                        dgvGlossary.Columns["Terminology"].Width = 250;
                    }
                    if (dgvGlossary.Columns["Definition"] != null)
                    {
                        dgvGlossary.Columns["Definition"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading glossary: " + ex.Message);
            }
        }

        private void SetupSearchPlaceholder()
        {
            txtSearch.Text = placeholderText;
            txtSearch.ForeColor = Color.Gray;
        }

        #region Search Logic

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            // Remove placeholder text on focus
            if (txtSearch.Text == placeholderText)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            // Add placeholder text if empty
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholderText;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Real-time search filter
            if (bindingSource == null || txtSearch.Text == placeholderText)
            {
                return;
            }

            string searchTerm = txtSearch.Text.Replace("'", "''"); // Basic sanitation for filter

            // Filter on both Terminology and Definition columns
            bindingSource.Filter = string.Format(
                "Terminology LIKE '%{0}%' OR Definition LIKE '%{0}%'",
                searchTerm
            );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // The TextChanged event already handles filtering,
            // but clicking the button can ensure the filter is applied.
            txtSearch_TextChanged(sender, e);
        }

        #endregion

        #region Navigation
        // These methods are copied from your Dashboard2.cs to ensure
        // the navigation panel works correctly.



        #endregion

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard = new Dashboard2();
            this.Hide();
            dashboard.Show();
        }

        private void flashcardsButton_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();
            this.Hide();
            flashcards.Show();
        }

        private void quizzesButton_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            this.Hide();
            quizzes.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();
            schedule.Show();
        }

        private void progressButton_Click(object sender, EventArgs e)
        {

        }

        private void btnStudy_Click(object sender, EventArgs e)
        {
            StudySets studyForm = new StudySets();
            this.Hide();
            studyForm.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }

        private void btnAddNewTerm_Click(object sender, EventArgs e)
        {
            string newTerm = txtNewTerm.Text.Trim();
            string newDefinition = txtNewDefinition.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(newTerm) || string.IsNullOrWhiteSpace(newDefinition))
            {
                MessageBox.Show("Please enter both a terminology and a definition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO Glossary (Terminology, Definition) 
                                     VALUES (@Terminology, @Definition)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@Terminology", newTerm);
                        cmd.Parameters.AddWithValue("@Definition", newDefinition);

                        cmd.ExecuteNonQuery();
                    }
                }

               
                glossaryTable.Rows.Add(newTerm, newDefinition);

                
                txtNewTerm.Clear();
                txtNewDefinition.Clear();

                MessageBox.Show("New terminology added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error saving new terminology: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTerm_Click(object sender, EventArgs e)
        {
            
            if (dgvGlossary.CurrentRow == null)
            {
                MessageBox.Show("Please use the search to find a term and select it from the grid first.", "No Term Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string termToDelete = dgvGlossary.CurrentRow.Cells["Terminology"].Value.ToString();

            
            DialogResult confirmation = MessageBox.Show(
                $"Are you sure you want to permanently delete the term '{termToDelete}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmation != DialogResult.Yes)
            {
                return; 
            }

            
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    
                    string query = "DELETE FROM Glossary WHERE Terminology = @Terminology";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Terminology", termToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                            DataRowView rowView = (DataRowView)dgvGlossary.CurrentRow.DataBoundItem;
                            rowView.Row.Delete();

                            MessageBox.Show("Term deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error: Could not find the term in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting term: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}