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
            btnBack.Location = new Point(747, 556);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 31);
            btnBack.TabIndex = 4;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete_Patient
            // 
            btnDelete_Patient.AutoSize = true;
            btnDelete_Patient.Location = new Point(101, 207);
            btnDelete_Patient.Margin = new Padding(3, 4, 3, 4);
            btnDelete_Patient.Name = "btnDelete_Patient";
            btnDelete_Patient.Size = new Size(222, 33);
            btnDelete_Patient.TabIndex = 5;
            btnDelete_Patient.Text = "Delete Patient ID";
            btnDelete_Patient.UseVisualStyleBackColor = true;
            btnDelete_Patient.Click += btnDelete_Patient_Click;
            // 
            // button3
            // 
            button3.Location = new Point(101, 291);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(222, 31);
            button3.TabIndex = 6;
            button3.Text = "Adding Beds To Available List";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(101, 71);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 54);
            lblName.TabIndex = 11;
            lblName.Text = "label3";
            lblName.Click += label3_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(101, 374);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(222, 29);
            btnUsers.TabIndex = 12;
            btnUsers.Text = "All Users Info";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUsers);
            Controls.Add(lblName);
            Controls.Add(button3);
            Controls.Add(btnDelete_Patient);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Dashboard";
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