namespace QuizMe_
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label4 = new Label();
            txtEmailAdd = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(105, 287);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 215);
            label2.Name = "label2";
            label2.Size = new Size(367, 28);
            label2.TabIndex = 1;
            label2.Text = "Your future is built one chapter at a time!";
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
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 848);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(703, 166);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 11;
            label3.Text = "Log in";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1098, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(703, 273);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 19;
            label7.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(703, 384);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 20;
            label4.Text = "Password";
            // 
            // txtEmailAdd
            // 
            txtEmailAdd.Location = new Point(704, 307);
            txtEmailAdd.Multiline = true;
            txtEmailAdd.Name = "txtEmailAdd";
            txtEmailAdd.Size = new Size(191, 39);
            txtEmailAdd.TabIndex = 21;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(704, 413);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(191, 37);
            txtPass.TabIndex = 22;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Font = new Font("Segoe UI", 15F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(675, 570);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(459, 102);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(1000, 521);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 29;
            label5.Text = "Forgot Password?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(744, 809);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 36;
            label8.Text = "Don't have an account?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(892, 809);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 37;
            label9.Text = "Sign up";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 851);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmailAdd);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "SignIn";
            Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label4;
        private TextBox txtEmailAdd;
        private TextBox txtPass;
        private Button btnLogin;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label8;
        private Label label9;
    }
}