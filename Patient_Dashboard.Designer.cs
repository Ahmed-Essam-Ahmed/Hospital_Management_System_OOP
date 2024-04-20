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
            lblName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(78, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(350, 54);
            lblName.TabIndex = 0;
            lblName.Text = "Patient Dashboard";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(114, 208);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update Info";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnFollowUp
            // 
            btnFollowUp.Location = new Point(114, 299);
            btnFollowUp.Margin = new Padding(3, 4, 3, 4);
            btnFollowUp.Name = "btnFollowUp";
            btnFollowUp.Size = new Size(131, 31);
            btnFollowUp.TabIndex = 2;
            btnFollowUp.Text = "Follow -Up ";
            btnFollowUp.UseVisualStyleBackColor = true;
            btnFollowUp.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 553);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Patient_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBack);
            Controls.Add(btnFollowUp);
            Controls.Add(btnUpdate);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Patient_Dashboard";
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