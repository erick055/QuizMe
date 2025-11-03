namespace QuizMe_
{
    partial class RecoverAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverAccount));
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmailAdd = new TextBox();
            btnCode = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(693, 56);
            button1.Name = "button1";
            button1.Size = new Size(53, 49);
            button1.TabIndex = 6;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1090, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(693, 270);
            label5.Name = "label5";
            label5.Size = new Size(421, 50);
            label5.TabIndex = 15;
            label5.Text = "Don’t worry! It happens. \r\nPlease enter the email associated with your account.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(684, 177);
            label6.Name = "label6";
            label6.Size = new Size(178, 28);
            label6.TabIndex = 16;
            label6.Text = "Forgot Password?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(693, 380);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 17;
            label7.Text = "Email Address";
            // 
            // txtEmailAdd
            // 
            txtEmailAdd.Font = new Font("Segoe UI", 10F);
            txtEmailAdd.Location = new Point(693, 414);
            txtEmailAdd.Name = "txtEmailAdd";
            txtEmailAdd.Size = new Size(286, 25);
            txtEmailAdd.TabIndex = 18;
            // 
            // btnCode
            // 
            btnCode.BackColor = SystemColors.ActiveCaptionText;
            btnCode.Font = new Font("Segoe UI", 15F);
            btnCode.ForeColor = SystemColors.ButtonFace;
            btnCode.Location = new Point(693, 597);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(447, 102);
            btnCode.TabIndex = 19;
            btnCode.Text = "Send Code";
            btnCode.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 857);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 230);
            label2.Name = "label2";
            label2.Size = new Size(468, 56);
            label2.TabIndex = 1;
            label2.Text = "Focus now, shine later. \r\nYour hard work today is your strength for tomorrow.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(67, 57);
            label1.Name = "label1";
            label1.Size = new Size(333, 144);
            label1.TabIndex = 0;
            label1.Text = "Make \r\nlearning fun!";
            // 
            // RecoverAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 851);
            Controls.Add(btnCode);
            Controls.Add(txtEmailAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "RecoverAccount";
            Text = "RecoverAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmailAdd;
        private Button btnCode;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}