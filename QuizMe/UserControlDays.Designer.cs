namespace QuizMe_
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbDays = new Label();
            lblTime = new Label();
            lblIdentifier = new Label();
            SuspendLayout();
            // 
            // lbDays
            // 
            lbDays.AutoSize = true;
            lbDays.Font = new Font("Microsoft Sans Serif", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDays.Location = new Point(3, 0);
            lbDays.Name = "lbDays";
            lbDays.Size = new Size(24, 18);
            lbDays.TabIndex = 0;
            lbDays.Text = "00";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Red;
            lblTime.Location = new Point(3, 18);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 13);
            lblTime.TabIndex = 1;
            lblTime.Visible = false;
            // 
            // lblIdentifier
            // 
            lblIdentifier.AutoSize = true;
            lblIdentifier.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdentifier.ForeColor = Color.Red;
            lblIdentifier.Location = new Point(54, 18);
            lblIdentifier.Name = "lblIdentifier";
            lblIdentifier.Size = new Size(0, 13);
            lblIdentifier.TabIndex = 2;
            lblIdentifier.Visible = false;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIdentifier);
            Controls.Add(lblTime);
            Controls.Add(lbDays);
            Name = "UserControlDays";
            Size = new Size(117, 95);
            Load += UserControlDays_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDays;
        private Label lblTime;
        private Label lblIdentifier;
    }
}
