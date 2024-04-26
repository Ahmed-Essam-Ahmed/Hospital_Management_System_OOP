namespace Hospital_Managment_System_OOP
{
    partial class Patient_Dashboard
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
            lblName = new Label();
            btnUpdate = new Button();
            btnFollowUp = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Rockwell", 18F);
            lblName.ForeColor = Color.MediumPurple;
            lblName.Location = new Point(36, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(270, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Patient Dashboard";
            lblName.Click += lblName_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGray;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Rockwell", 13.8F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(114, 248);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(282, 53);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Info";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.BackColor = Color.LightGray;
            btnFollowUp.FlatAppearance.BorderSize = 0;
            btnFollowUp.FlatStyle = FlatStyle.Flat;
            btnFollowUp.Font = new Font("Rockwell", 13.8F);
            btnFollowUp.ForeColor = Color.White;
            btnFollowUp.Location = new Point(114, 375);
            btnFollowUp.Margin = new Padding(3, 4, 3, 4);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(282, 53);
            btnFollowUp.TabIndex = 2;
            btnFollowUp.Text = "Follow - Up ";
            btnFollowUp.UseVisualStyleBackColor = false;
            btnFollowUp.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(395, 652);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Patient_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 696);
            Controls.Add(btnBack);
            Controls.Add(btnFollowUp);
            Controls.Add(btnUpdate);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient_Dashboard";
            Load += Patient_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnUpdate;
        private Button btnFollowUp;
        private Button btnBack;
    }
}