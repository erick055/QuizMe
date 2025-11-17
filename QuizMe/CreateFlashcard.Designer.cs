namespace QuizMe_
{
    partial class CreateFlashcard
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
            txtQuestion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAnswer = new TextBox();
            buttonSubmit = new Button();
            backBtn = new Button();
            dtpScheduleDate = new DateTimePicker();
            label3 = new Label();
            cmbStudySets = new ComboBox();
            chkEnableSchedule = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(59, 96);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(237, 70);
            txtQuestion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Question:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 188);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Answer:";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(59, 206);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(237, 71);
            txtAnswer.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(114, 302);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(126, 44);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(139, 363);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 5;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // dtpScheduleDate
            // 
            dtpScheduleDate.CustomFormat = "MMMM dd, yyyy hh:mm tt";
            dtpScheduleDate.Format = DateTimePickerFormat.Custom;
            dtpScheduleDate.Location = new Point(77, 425);
            dtpScheduleDate.Name = "dtpScheduleDate";
            dtpScheduleDate.ShowUpDown = true;
            dtpScheduleDate.Size = new Size(200, 23);
            dtpScheduleDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 407);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 7;
            label3.Text = "Schedule Flashcard:";
            // 
            // cmbStudySets
            // 
            cmbStudySets.FormattingEnabled = true;
            cmbStudySets.Location = new Point(59, 67);
            cmbStudySets.Name = "cmbStudySets";
            cmbStudySets.Size = new Size(237, 23);
            cmbStudySets.TabIndex = 8;
            cmbStudySets.Text = "Select Study Set (Optional)";
            // 
            // chkEnableSchedule
            // 
            chkEnableSchedule.AutoSize = true;
            chkEnableSchedule.Location = new Point(191, 408);
            chkEnableSchedule.Name = "chkEnableSchedule";
            chkEnableSchedule.Size = new Size(15, 14);
            chkEnableSchedule.TabIndex = 9;
            chkEnableSchedule.UseVisualStyleBackColor = true;
            chkEnableSchedule.CheckedChanged += chkEnableSchedule_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 20);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 10;
            label4.Text = "Create Flashcard";
            // 
            // CreateFlashcard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 526);
            Controls.Add(label4);
            Controls.Add(chkEnableSchedule);
            Controls.Add(cmbStudySets);
            Controls.Add(label3);
            Controls.Add(dtpScheduleDate);
            Controls.Add(backBtn);
            Controls.Add(buttonSubmit);
            Controls.Add(label2);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(txtQuestion);
            Name = "CreateFlashcard";
            Text = "CreateFlashcard";
            Load += CreateFlashcard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuestion;
        private Label label1;
        private Label label2;
        private TextBox txtAnswer;
        private Button buttonSubmit;
        private Button backBtn;
        private DateTimePicker dtpScheduleDate;
        private Label label3;
        private ComboBox cmbStudySets;
        private CheckBox chkEnableSchedule;
        private Label label4;
    }
}