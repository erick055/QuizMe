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
    public partial class Dashboard2 : Form
    {
        SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;");

        public Dashboard2()
        {
            InitializeComponent();
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
            Progress progress = new Progress();
            this.Hide();

            progress.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();

            settings.Show();
        }

       

        private void Dashboard2_Load(object sender, EventArgs e)
        {

        }
    }
}
