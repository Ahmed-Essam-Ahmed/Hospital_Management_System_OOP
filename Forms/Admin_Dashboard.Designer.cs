namespace Hospital_Managment_System_OOP
{
    partial class Admin_Dashboard
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
            btnBack = new Button();
            btnDelete_Patient = new Button();
            button3 = new Button();
            lblName = new Label();
            btnUsers = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(395, 652);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 4;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete_Patient
            // 
            btnDelete_Patient.AutoSize = true;
            btnDelete_Patient.BackColor = Color.LightGray;
            btnDelete_Patient.FlatAppearance.BorderSize = 0;
            btnDelete_Patient.FlatStyle = FlatStyle.Flat;
            btnDelete_Patient.Font = new Font("Rockwell", 13.8F);
            btnDelete_Patient.ForeColor = Color.White;
            btnDelete_Patient.Location = new Point(101, 295);
            btnDelete_Patient.Margin = new Padding(3, 4, 3, 4);
            btnDelete_Patient.Name = "btnDelete_Patient";
            btnDelete_Patient.Size = new Size(282, 48);
            btnDelete_Patient.TabIndex = 5;
            btnDelete_Patient.Text = "Delete Patient ID";
            btnDelete_Patient.UseVisualStyleBackColor = false;
            btnDelete_Patient.Click += btnDelete_Patient_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Rockwell", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(101, 381);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(282, 76);
            button3.TabIndex = 6;
            button3.Text = "Adding Beds To Available List";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MediumPurple;
            lblName.Location = new Point(31, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(268, 35);
            lblName.TabIndex = 11;
            lblName.Text = "Admin Dashboard\r\n";
            lblName.Click += label3_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.LightGray;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Rockwell", 13.8F);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(101, 203);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(282, 53);
            btnUsers.TabIndex = 12;
            btnUsers.Text = "All Users Info";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 696);
            Controls.Add(btnUsers);
            Controls.Add(lblName);
            Controls.Add(button3);
            Controls.Add(btnDelete_Patient);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete_Patient;
        private Button button3;
        private Label lblName;
        private Button btnUsers;
    }
}