namespace QuizMe_
{
    partial class CreateQuizzes
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
            label1.Location = new Point(59, 78);
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
            // CreateQuizzes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 447);
            Controls.Add(backBtn);
            Controls.Add(buttonSubmit);
            Controls.Add(label2);
            Controls.Add(txtAnswer);
            Controls.Add(label1);
            Controls.Add(txtQuestion);
            Name = "CreateQuizzes";
            Text = "CreateFlashcard";
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
    }
}
