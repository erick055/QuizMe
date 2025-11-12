namespace QuizMe_
{
    partial class PasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChange));
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            btnBackToLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 215);
            label2.Name = "label2";
            label2.Size = new Size(496, 56);
            label2.TabIndex = 1;
            label2.Text = "Don’t count the hours you study, make the hours count.\r\n Every moment spent learning adds up to your success.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(76, 52);
            label1.Name = "label1";
            label1.Size = new Size(333, 144);
            label1.TabIndex = 0;
            label1.Text = "Make \r\nlearning fun!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 848);
            panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(862, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(922, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(667, 310);
            label3.Name = "label3";
            label3.Size = new Size(189, 28);
            label3.TabIndex = 18;
            label3.Text = "Password Changed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(733, 460);
            label4.Name = "label4";
            label4.Size = new Size(283, 50);
            label4.TabIndex = 19;
            label4.Text = "Your password has been changed \r\n                   succesfully";
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = SystemColors.ActiveCaptionText;
            btnBackToLogin.Font = new Font("Segoe UI", 15F);
            btnBackToLogin.ForeColor = SystemColors.ButtonFace;
            btnBackToLogin.Location = new Point(642, 581);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(459, 102);
            btnBackToLogin.TabIndex = 27;
            btnBackToLogin.Text = "Back to login";
            btnBackToLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
           
            pictureBox1.Location = new Point(216, 438);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 407);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 851);
            Controls.Add(btnBackToLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "PasswordChange";
            Text = "PasswordChange";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnBackToLogin;
    }
}