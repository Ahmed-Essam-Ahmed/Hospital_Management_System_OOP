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
            label1 = new Label();
            btnUpdate = new Button();
            btnFollowUp = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 42);
            label1.Name = "label1";
            label1.Size = new Size(281, 45);
            label1.TabIndex = 0;
            label1.Text = "Patient Dashboard";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(100, 156);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Info";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Location = new Point(100, 224);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(115, 23);
            btnFollowUp.TabIndex = 2;
            btnFollowUp.Text = "Follow -Up ";
            btnFollowUp.UseVisualStyleBackColor = true;
            btnFollowUp.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Patient_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnFollowUp);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "Patient_Dashboard";
            Text = "Patient_Dashboard";
            Load += Patient_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUpdate;
        private Button btnFollowUp;
        private Button btnBack;
    }
}