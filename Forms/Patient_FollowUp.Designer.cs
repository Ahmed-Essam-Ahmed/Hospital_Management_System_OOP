namespace Hospital_Managment_System_OOP
{
    partial class Patient_FollowUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnHome = new Button();
            btnBack = new Button();
            label5 = new Label();
            lblDosage = new Label();
            lblDisease = new Label();
            lblSymptoms = new Label();
            lblMedicine = new Label();
            lblDose = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Rockwell", 12F);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(72, 246);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 1;
            label1.Text = "Symptoms:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Rockwell", 12F);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(72, 180);
            label2.Name = "label2";
            label2.Size = new Size(193, 22);
            label2.TabIndex = 2;
            label2.Text = "Prescribed Disease:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Rockwell", 12F);
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(72, 305);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 3;
            label3.Text = "Medicine:";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Silver;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Rockwell", 10.8F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(646, 556);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 31);
            btnHome.TabIndex = 5;
            btnHome.Text = "Log Out";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 556);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 31);
            btnBack.TabIndex = 6;
            btnBack.Text = "Homepage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumPurple;
            label5.Location = new Point(38, 46);
            label5.Name = "label5";
            label5.Size = new Size(256, 35);
            label5.TabIndex = 7;
            label5.Text = "Patient Follow Up";
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.FlatStyle = FlatStyle.Flat;
            lblDosage.Font = new Font("Rockwell", 12F);
            lblDosage.ForeColor = SystemColors.InfoText;
            lblDosage.Location = new Point(72, 365);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(86, 22);
            lblDosage.TabIndex = 8;
            lblDosage.Text = "Dosage:";
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.FlatStyle = FlatStyle.Flat;
            lblDisease.Font = new Font("Rockwell", 12F);
            lblDisease.ForeColor = SystemColors.ButtonShadow;
            lblDisease.Location = new Point(271, 180);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(68, 22);
            lblDisease.TabIndex = 9;
            lblDisease.Text = "label4";
            // 
            // lblSymptoms
            // 
            lblSymptoms.AutoSize = true;
            lblSymptoms.FlatStyle = FlatStyle.Flat;
            lblSymptoms.Font = new Font("Rockwell", 12F);
            lblSymptoms.ForeColor = SystemColors.ButtonShadow;
            lblSymptoms.Location = new Point(197, 246);
            lblSymptoms.Name = "lblSymptoms";
            lblSymptoms.Size = new Size(68, 22);
            lblSymptoms.TabIndex = 10;
            lblSymptoms.Text = "label6";
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.FlatStyle = FlatStyle.Flat;
            lblMedicine.Font = new Font("Rockwell", 12F);
            lblMedicine.ForeColor = SystemColors.ButtonShadow;
            lblMedicine.Location = new Point(197, 305);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(68, 22);
            lblMedicine.TabIndex = 11;
            lblMedicine.Text = "label7";
            // 
            // lblDose
            // 
            lblDose.AutoSize = true;
            lblDose.FlatStyle = FlatStyle.Flat;
            lblDose.Font = new Font("Rockwell", 12F);
            lblDose.ForeColor = SystemColors.ButtonShadow;
            lblDose.Location = new Point(197, 365);
            lblDose.Name = "lblDose";
            lblDose.Size = new Size(68, 22);
            lblDose.TabIndex = 12;
            lblDose.Text = "label8";
            // 
            // Patient_FollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 600);
            Controls.Add(lblDose);
            Controls.Add(lblMedicine);
            Controls.Add(lblSymptoms);
            Controls.Add(lblDisease);
            Controls.Add(lblDosage);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient_FollowUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient_FollowUp";
            Load += Patient_FollowUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnHome;
        private Button btnBack;
        private Label label5;
        private Label lblDosage;
        private Label lblDisease;
        private Label lblSymptoms;
        private Label lblMedicine;
        private Label lblDose;
    }
}