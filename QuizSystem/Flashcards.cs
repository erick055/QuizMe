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
    public partial class Flashcards : Form
    {
        public Flashcards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard = new Dashboard2();
            this.Hide();

            dashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            this.Hide();

            quizzes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            this.Hide();


            schedule.Show();
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
    }
}
