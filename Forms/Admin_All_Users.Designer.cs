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
            AdminGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminGrid.Location = new Point(12, 148);
            AdminGrid.Name = "AdminGrid";
            AdminGrid.ReadOnly = true;
            AdminGrid.RowHeadersWidth = 51;
            AdminGrid.Size = new Size(365, 172);
            AdminGrid.TabIndex = 0;
            // 
            // FrontDeskGrid
            // 
            FrontDeskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FrontDeskGrid.Location = new Point(545, 148);
            FrontDeskGrid.Name = "FrontDeskGrid";
            FrontDeskGrid.ReadOnly = true;
            FrontDeskGrid.RowHeadersWidth = 51;
            FrontDeskGrid.Size = new Size(372, 172);
            FrontDeskGrid.TabIndex = 1;
            // 
            // PatientGrid
            // 
            PatientGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGrid.Location = new Point(12, 346);
            PatientGrid.Name = "PatientGrid";
            PatientGrid.ReadOnly = true;
            PatientGrid.RowHeadersWidth = 51;
            PatientGrid.Size = new Size(905, 229);
            PatientGrid.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(804, 581);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 581);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(173, 29);
            btnHome.TabIndex = 4;
            btnHome.Text = "Homepage";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 9);
            label2.Name = "label2";
            label2.Size = new Size(395, 54);
            label2.TabIndex = 6;
            label2.Text = "All Users Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 323);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 7;
            label3.Text = "Patients Accounts";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 105);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 8;
            label4.Text = "Front Desk Accounts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 105);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 9;
            label5.Text = "Admin Accounts";
            // 
            // Admin_All_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "Admin_All_Users";
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