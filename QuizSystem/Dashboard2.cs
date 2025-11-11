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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void fcButton_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();
            this.Hide();

            flashcards.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();

            progress.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();

            settings.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();

            schedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            this.Hide();

            quizzes.Show();
        }
    }
}
