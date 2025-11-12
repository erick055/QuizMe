using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class Quizzes : Form
    {
        public Quizzes()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            this.Hide();
            settings.Show();
        }

        private void progressButton_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();


            progress.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();
            schedule.Show();
        }

        private void glossaryButton_Click(object sender, EventArgs e)
        {

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
    }
}
