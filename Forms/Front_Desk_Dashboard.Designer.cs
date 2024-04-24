namespace Hospital_Managment_System_OOP
{
    partial class Front_Desk_Dashboard
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
            btnAdd = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(69, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(418, 54);
            lblName.TabIndex = 0;
            lblName.Text = "Front Desk Dashboard";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(102, 255);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(191, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add a New Patient";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(816, 556);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Front_Desk_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Front_Desk_Dashboard";
            Text = "Front_Desk_Dashboard";
            Load += Front_Desk_Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnAdd;
        private Button btnBack;
    }
}