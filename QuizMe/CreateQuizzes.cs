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
    public partial class CreateQuizzes : Form
    {
        public CreateQuizzes()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();    
            this.Hide();

            quizzes.Show();
        }
    }
}
