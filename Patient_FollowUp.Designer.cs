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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 193);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Symptoms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 141);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Prescribed Disease";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 237);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Medicine";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(647, 415);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(141, 23);
            btnHome.TabIndex = 5;
            btnHome.Text = "Return to Homepage";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(80, 46);
            label5.Name = "label5";
            label5.Size = new Size(270, 45);
            label5.TabIndex = 7;
            label5.Text = "Patient Follow Up";
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new Point(80, 282);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(46, 15);
            lblDosage.TabIndex = 8;
            lblDosage.Text = "Dosage";
            // 
            // Patient_FollowUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDosage);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Patient_FollowUp";
            Text = "Patient_FollowUp";
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
    }
}