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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }



        private void btnSched_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();

            schedule.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();
            progress.Show();

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

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            this.Hide();

            dashboard2.Show();
        }
    }
}
