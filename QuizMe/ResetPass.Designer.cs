namespace QuizMe_
{
    partial class ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPass));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtConfirmPass = new Label();
            btnResetPass = new Button();
            textBox2 = new TextBox();
            txtNewpass = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(663, 43);
            button1.Name = "button1";
            button1.Size = new Size(53, 49);
            button1.TabIndex = 9;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 215);
            label2.Name = "label2";
            label2.Size = new Size(508, 56);
            label2.TabIndex = 1;
            label2.Text = "Discipline in learning today shapes excellence tomorrow. \r\nEducation is the foundation of every achievement.";
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
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 848);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(100, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1079, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(640, 216);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 16;
            label3.Text = "Reset Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(640, 283);
            label4.Name = "label4";
            label4.Size = new Size(325, 25);
            label4.TabIndex = 17;
            label4.Text = "Please type something you'll remember";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(640, 418);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 18;
            label5.Text = "New password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.AutoSize = true;
            txtConfirmPass.Font = new Font("Segoe UI", 10F);
            txtConfirmPass.Location = new Point(640, 520);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(120, 19);
            txtConfirmPass.TabIndex = 19;
            txtConfirmPass.Text = "Confirm Password";
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = SystemColors.ActiveCaptionText;
            btnResetPass.Font = new Font("Segoe UI", 15F);
            btnResetPass.ForeColor = SystemColors.ButtonFace;
            btnResetPass.Location = new Point(640, 638);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(459, 102);
            btnResetPass.TabIndex = 26;
            btnResetPass.Text = "Reset Password";
            btnResetPass.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(644, 551);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 42);
            textBox2.TabIndex = 28;
            // 
            // txtNewpass
            // 
            txtNewpass.Location = new Point(640, 451);
            txtNewpass.Multiline = true;
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(271, 42);
            txtNewpass.TabIndex = 29;
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 851);
            Controls.Add(txtNewpass);
            Controls.Add(textBox2);
            Controls.Add(btnResetPass);
            Controls.Add(txtConfirmPass);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ResetPass";
            Text = "ResetPass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtConfirmPass;
        private Button btnResetPass;
        private TextBox textBox2;
        private TextBox txtNewpass;
    }
}