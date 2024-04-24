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
            label1.Location = new Point(75, 257);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Symptoms:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 188);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 2;
            label2.Text = "Prescribed Disease:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 316);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Medicine:";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(739, 553);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(161, 31);
            btnHome.TabIndex = 5;
            btnHome.Text = "Log Out";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 553);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 31);
            btnBack.TabIndex = 6;
            btnBack.Text = "Homepage";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(91, 61);
            label5.Name = "label5";
            label5.Size = new Size(334, 54);
            label5.TabIndex = 7;
            label5.Text = "Patient Follow Up";
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new Point(75, 376);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(63, 20);
            lblDosage.TabIndex = 8;
            lblDosage.Text = "Dosage:";
            // 
            // lblDisease
            // 
            lblDisease.AutoSize = true;
            lblDisease.Location = new Point(215, 188);
            lblDisease.Name = "lblDisease";
            lblDisease.Size = new Size(50, 20);
            lblDisease.TabIndex = 9;
            lblDisease.Text = "label4";
            // 
            // lblSymptoms
            // 
            lblSymptoms.AutoSize = true;
            lblSymptoms.Location = new Point(215, 257);
            lblSymptoms.Name = "lblSymptoms";
            lblSymptoms.Size = new Size(50, 20);
            lblSymptoms.TabIndex = 10;
            lblSymptoms.Text = "label6";
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Location = new Point(215, 316);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(50, 20);
            lblMedicine.TabIndex = 11;
            lblMedicine.Text = "label7";
            // 
            // lblDose
            // 
            lblDose.AutoSize = true;
            lblDose.Location = new Point(215, 376);
            lblDose.Name = "lblDose";
            lblDose.Size = new Size(50, 20);
            lblDose.TabIndex = 12;
            lblDose.Text = "label8";
            // 
            // Patient_FollowUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient_FollowUp";
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