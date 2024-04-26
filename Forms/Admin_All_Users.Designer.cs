namespace Hospital_Managment_System_OOP
{
    partial class Admin_All_Users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AdminGrid = new DataGridView();
            FrontDeskGrid = new DataGridView();
            PatientGrid = new DataGridView();
            btnLogout = new Button();
            btnHome = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)AdminGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontDeskGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientGrid).BeginInit();
            SuspendLayout();
            // 
            // AdminGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            AdminGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AdminGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdminGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AdminGrid.BackgroundColor = Color.Silver;
            AdminGrid.BorderStyle = BorderStyle.None;
            AdminGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AdminGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminGrid.Location = new Point(12, 119);
            AdminGrid.Name = "AdminGrid";
            AdminGrid.ReadOnly = true;
            AdminGrid.RowHeadersWidth = 51;
            AdminGrid.Size = new Size(377, 172);
            AdminGrid.TabIndex = 0;
            // 
            // FrontDeskGrid
            // 
            FrontDeskGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            FrontDeskGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FrontDeskGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FrontDeskGrid.BackgroundColor = Color.Silver;
            FrontDeskGrid.BorderStyle = BorderStyle.None;
            FrontDeskGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            FrontDeskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FrontDeskGrid.Location = new Point(552, 119);
            FrontDeskGrid.Name = "FrontDeskGrid";
            FrontDeskGrid.ReadOnly = true;
            FrontDeskGrid.RowHeadersWidth = 51;
            FrontDeskGrid.Size = new Size(376, 172);
            FrontDeskGrid.TabIndex = 1;
            // 
            // PatientGrid
            // 
            PatientGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PatientGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PatientGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PatientGrid.BackgroundColor = Color.Silver;
            PatientGrid.BorderStyle = BorderStyle.None;
            PatientGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PatientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGrid.Location = new Point(12, 334);
            PatientGrid.Name = "PatientGrid";
            PatientGrid.ReadOnly = true;
            PatientGrid.RowHeadersWidth = 51;
            PatientGrid.Size = new Size(916, 229);
            PatientGrid.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Rockwell", 10.8F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(842, 581);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Silver;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Rockwell", 10.8F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(12, 581);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(131, 31);
            btnHome.TabIndex = 4;
            btnHome.Text = "Homepage";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F);
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(43, 40);
            label2.Name = "label2";
            label2.Size = new Size(307, 35);
            label2.TabIndex = 6;
            label2.Text = "All Users Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(385, 309);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 7;
            label3.Text = "Patients Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(655, 94);
            label4.Name = "label4";
            label4.Size = new Size(195, 22);
            label4.TabIndex = 8;
            label4.Text = "Front Desk Accounts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(92, 94);
            label5.Name = "label5";
            label5.Size = new Size(158, 22);
            label5.TabIndex = 9;
            label5.Text = "Admin Accounts";
            // 
            // Admin_All_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(940, 622);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(PatientGrid);
            Controls.Add(FrontDeskGrid);
            Controls.Add(AdminGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_All_Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_All_Users";
            Load += Admin_All_Users_Load;
            ((System.ComponentModel.ISupportInitialize)AdminGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontDeskGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AdminGrid;
        private DataGridView FrontDeskGrid;
        private DataGridView PatientGrid;
        private Button btnLogout;
        private Button btnHome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}