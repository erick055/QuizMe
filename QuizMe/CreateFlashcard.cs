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
    public partial class CreateFlashcard : Form
    {
        public CreateFlashcard()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();

            this.Hide();

            flashcards.Show();
        }
    }
}
