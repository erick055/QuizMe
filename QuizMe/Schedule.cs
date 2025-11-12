using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace QuizMe_
{
    public partial class Schedule : Form
    {
        int month, year;
        SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=QuizMeDB;Trusted_Connection=True;");

        // --- MODIFIED ---
        // This will store the Date and the *first* scheduled time for that date
        Dictionary<DateTime, DateTime> scheduledDates = new Dictionary<DateTime, DateTime>();
        // --- END OF MODIFICATION ---

        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        // --- MODIFIED ---
        // This query now gets the MIN(schedule_date) for each day
        private void LoadScheduledDates(int year, int month)
        {
            scheduledDates.Clear();
            try
            {
                con.Open();
                // This query groups by the date and gets the earliest time for each day
                string query = @"SELECT 
                                     CAST(schedule_date AS DATE) as schedule_day, 
                                     MIN(schedule_date) as first_schedule
                                 FROM Flashcards 
                                 WHERE user_id = @user_id 
                                   AND YEAR(schedule_date) = @year 
                                   AND MONTH(schedule_date) = @month
                                 GROUP BY CAST(schedule_date AS DATE)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", SignIn.staticUserID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime day = Convert.ToDateTime(reader["schedule_day"]);
                            DateTime firstTime = Convert.ToDateTime(reader["first_schedule"]);
                            scheduledDates[day] = firstTime;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schedule: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        // --- END OF MODIFICATION ---

        private void displayDays()
        {
            flpDayContainer.Controls.Clear(); // <-- Moved this to the top

            DateTime now = DateTime.Now;
            if (month == 0) month = now.Month;
            if (year == 0) year = now.Year;

            LoadScheduledDates(year, month);

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

                DateTime currentDay = new DateTime(year, month, i);
                ucDays.Tag = currentDay;

                // Check if this day is in our dictionary
                if (scheduledDates.ContainsKey(currentDay.Date))
                {
                    // Get the time
                    DateTime firstTime = scheduledDates[currentDay.Date];

                    // Set the time on the user control
                    ucDays.SetTime(firstTime.ToString("hh:mm tt"));

                    // --- THIS IS THE NEW LINE ---
                    ucDays.SetIdentifier("Flashcard"); // Set the "Flashcard" label
                                                       // --- END OF NEW LINE ---

                    // Mark the day
                    ucDays.BackColor = Color.LightBlue;
                }

                ucDays.Click += UcDays_Click;
                flpDayContainer.Controls.Add(ucDays);
            }
        }

        private void UcDays_Click(object sender, EventArgs e)
        {
            UserControlDays ucDay = (UserControlDays)sender;
            DateTime clickedDate = (DateTime)ucDay.Tag;
            Flashcards viewDayCards = new Flashcards(clickedDate);
            viewDayCards.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            displayDays();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            displayDays();
        }

        // --- (All your other navigation buttons remain the same) ---
        // ... (button7_Click, btnProg_Click, etc.) ...

        private void button7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }

        private void btnProg_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            this.Hide();
            progress.Show();
        }

        private void btnSched_Click(object sender, EventArgs e)
        {

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
            Dashboard2 dashboard = new Dashboard2();
            this.Hide();
            dashboard.Show();
        }
    }
}