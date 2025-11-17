namespace QuizMe_
{
    partial class Quizzes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            yes = new Label();
            panel13 = new Panel();
            btnStudy = new Button();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            settingsButton = new Button();
            scheduleButton = new Button();
            glossaryButton = new Button();
            quizzesButton = new Button();
            flashcardsButton = new Button();
            dashboardButton = new Button();
            createQuizzButton = new Button();
            flpAvailableQuizzes = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            lblRecentScore3 = new Label();
            lblRecentScore2 = new Label();
            lblRecentScore1 = new Label();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            yes.Location = new Point(262, 31);
            yes.Name = "yes";
            yes.Size = new Size(167, 30);
            yes.TabIndex = 1;
            yes.Text = "Avaible Quizzes";
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ActiveCaption;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(btnStudy);
            panel13.Controls.Add(pictureBox9);
            panel13.Controls.Add(pictureBox10);
            panel13.Controls.Add(pictureBox11);
            panel13.Controls.Add(pictureBox12);
            panel13.Controls.Add(pictureBox13);
            panel13.Controls.Add(pictureBox14);
            panel13.Controls.Add(settingsButton);
            panel13.Controls.Add(scheduleButton);
            panel13.Controls.Add(glossaryButton);
            panel13.Controls.Add(quizzesButton);
            panel13.Controls.Add(flashcardsButton);
            panel13.Controls.Add(dashboardButton);
            panel13.ForeColor = Color.Black;
            panel13.Location = new Point(10, 31);
            panel13.Margin = new Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new Size(225, 769);
            panel13.TabIndex = 29;
            // 
            // btnStudy
            // 
            btnStudy.Location = new Point(47, 343);
            btnStudy.Margin = new Padding(2);
            btnStudy.Name = "btnStudy";
            btnStudy.Size = new Size(145, 63);
            btnStudy.TabIndex = 33;
            btnStudy.Text = "Study Set";
            btnStudy.UseVisualStyleBackColor = true;
            btnStudy.Click += btnStudy_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.Settings;
            pictureBox9.Location = new Point(10, 424);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 32);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            pictureBox9.UseWaitCursor = true;
            pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.White;
            pictureBox10.Image = Properties.Resources.schedule;
            pictureBox10.Location = new Point(10, 292);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(31, 32);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            pictureBox10.UseWaitCursor = true;
            pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.White;
            pictureBox11.Image = Properties.Resources.Glossary;
            pictureBox11.Location = new Point(10, 228);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(31, 32);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 12;
            pictureBox11.TabStop = false;
            pictureBox11.UseWaitCursor = true;
            pictureBox11.Visible = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Image = Properties.Resources.Generated_Quiz;
            pictureBox12.Location = new Point(10, 167);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(31, 32);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 11;
            pictureBox12.TabStop = false;
            pictureBox12.UseWaitCursor = true;
            pictureBox12.Visible = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.White;
            pictureBox13.Image = Properties.Resources.Flashcards;
            pictureBox13.Location = new Point(10, 107);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(31, 32);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 10;
            pictureBox13.TabStop = false;
            pictureBox13.UseWaitCursor = true;
            pictureBox13.Visible = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.White;
            pictureBox14.Image = Properties.Resources.dashboard;
            pictureBox14.Location = new Point(10, 51);
            pictureBox14.Margin = new Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(31, 32);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 9;
            pictureBox14.TabStop = false;
            pictureBox14.UseWaitCursor = true;
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(47, 410);
            settingsButton.Margin = new Padding(2);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(145, 63);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += button7_Click;
            // 
            // scheduleButton
            // 
            scheduleButton.Location = new Point(47, 282);
            scheduleButton.Margin = new Padding(2);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(145, 57);
            scheduleButton.TabIndex = 4;
            scheduleButton.Text = "Schedule";
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Click += scheduleButton_Click;
            // 
            // glossaryButton
            // 
            glossaryButton.Location = new Point(47, 218);
            glossaryButton.Margin = new Padding(2);
            glossaryButton.Name = "glossaryButton";
            glossaryButton.Size = new Size(145, 58);
            glossaryButton.TabIndex = 3;
            glossaryButton.Text = "Glossary";
            glossaryButton.UseVisualStyleBackColor = true;
            glossaryButton.Click += glossaryButton_Click;
            // 
            // quizzesButton
            // 
            quizzesButton.Location = new Point(47, 157);
            quizzesButton.Margin = new Padding(2);
            quizzesButton.Name = "quizzesButton";
            quizzesButton.Size = new Size(145, 53);
            quizzesButton.TabIndex = 2;
            quizzesButton.Text = "Quizzes";
            quizzesButton.UseVisualStyleBackColor = true;
            quizzesButton.Click += quizzesButton_Click;
            // 
            // flashcardsButton
            // 
            flashcardsButton.Location = new Point(47, 98);
            flashcardsButton.Margin = new Padding(2);
            flashcardsButton.Name = "flashcardsButton";
            flashcardsButton.Size = new Size(145, 54);
            flashcardsButton.TabIndex = 1;
            flashcardsButton.Text = "Flashcards";
            flashcardsButton.UseVisualStyleBackColor = true;
            flashcardsButton.Click += flashcardsButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Location = new Point(47, 38);
            dashboardButton.Margin = new Padding(2);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(145, 54);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // createQuizzButton
            // 
            createQuizzButton.Location = new Point(1064, 31);
            createQuizzButton.Name = "createQuizzButton";
            createQuizzButton.Size = new Size(119, 23);
            createQuizzButton.TabIndex = 30;
            createQuizzButton.Text = "Create Quiz";
            createQuizzButton.UseVisualStyleBackColor = true;
            createQuizzButton.Click += createQuizzButton_Click;
            // 
            // flpAvailableQuizzes
            // 
            flpAvailableQuizzes.Location = new Point(262, 69);
            flpAvailableQuizzes.Name = "flpAvailableQuizzes";
            flpAvailableQuizzes.Size = new Size(771, 632);
            flpAvailableQuizzes.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(1051, 69);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 3;
            label1.Text = "Recent Scores:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRecentScore3);
            panel1.Controls.Add(lblRecentScore2);
            panel1.Controls.Add(lblRecentScore1);
            panel1.Location = new Point(1051, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 496);
            panel1.TabIndex = 32;
            // 
            // lblRecentScore3
            // 
            lblRecentScore3.AutoSize = true;
            lblRecentScore3.Location = new Point(27, 56);
            lblRecentScore3.Name = "lblRecentScore3";
            lblRecentScore3.Size = new Size(38, 15);
            lblRecentScore3.TabIndex = 2;
            lblRecentScore3.Text = "label5";
            // 
            // lblRecentScore2
            // 
            lblRecentScore2.AutoSize = true;
            lblRecentScore2.Location = new Point(27, 41);
            lblRecentScore2.Name = "lblRecentScore2";
            lblRecentScore2.Size = new Size(38, 15);
            lblRecentScore2.TabIndex = 1;
            lblRecentScore2.Text = "label2";
            // 
            // lblRecentScore1
            // 
            lblRecentScore1.AutoSize = true;
            lblRecentScore1.Location = new Point(27, 26);
            lblRecentScore1.Name = "lblRecentScore1";
            lblRecentScore1.Size = new Size(38, 15);
            lblRecentScore1.TabIndex = 0;
            lblRecentScore1.Text = "label2";
            // 
            // Quizzes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1415, 1061);
            Controls.Add(panel1);
            Controls.Add(flpAvailableQuizzes);
            Controls.Add(createQuizzButton);
            Controls.Add(panel13);
            Controls.Add(label1);
            Controls.Add(yes);
            Name = "Quizzes";
            Text = "Quizzes";
            Load += Quizzes_Load;
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label yes;
        private Panel panel13;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private Button settingsButton;
        private Button scheduleButton;
        private Button glossaryButton;
        private Button quizzesButton;
        private Button flashcardsButton;
        private Button dashboardButton;
        private Button createQuizzButton;
        private FlowLayoutPanel flpAvailableQuizzes;
        private Button btnStudy;
        private Label label1;
        private Panel panel1;
        private Label lblRecentScore3;
        private Label lblRecentScore2;
        private Label lblRecentScore1;
    }
}