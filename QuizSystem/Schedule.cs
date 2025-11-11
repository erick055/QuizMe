using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuizMe_
{
    public partial class Schedule : Form
    {
        int month, year;
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;

            DateTime StartOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysofWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flpDayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flpDayContainer.Controls.Add(ucDays);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            flpDayContainer.Controls.Clear();

            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++; ;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;
            DateTime StartOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysofWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flpDayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flpDayContainer.Controls.Add(ucDays);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            flpDayContainer.Controls.Clear();

            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthName + " " + year;
            DateTime StartOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int daysofWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < daysofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flpDayContainer.Controls.Add(ucBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.days(i);
                flpDayContainer.Controls.Add(ucDays);
            }
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();

            progress.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard = new Dashboard2();
            this.Hide();

            dashboard.Show();
        }

        private void btnFlashcard_Click(object sender, EventArgs e)
        {
            Flashcards flashcards = new Flashcards();
            this.Hide();

            flashcards.Show();

        }

        private void btnQuizzes_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            this.Hide();

            quizzes.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }
    }
}
