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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(8, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete_Patient
            // 
            btnDelete_Patient.AutoSize = true;
            btnDelete_Patient.Location = new Point(88, 155);
            btnDelete_Patient.Name = "btnDelete_Patient";
            btnDelete_Patient.Size = new Size(104, 25);
            btnDelete_Patient.TabIndex = 5;
            btnDelete_Patient.Text = "Delete Patient ID";
            btnDelete_Patient.UseVisualStyleBackColor = true;
            btnDelete_Patient.Click += btnDelete_Patient_Click;
            // 
            // button3
            // 
            button3.Location = new Point(88, 218);
            button3.Name = "button3";
            button3.Size = new Size(194, 23);
            button3.TabIndex = 6;
            button3.Text = "Adding Beds To Available List";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 34);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 9;
            label1.Text = "Admin Dashboard";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnDelete_Patient);
            Controls.Add(btnBack);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete_Patient;
        private Button button3;
        private Label label1;
    }
}