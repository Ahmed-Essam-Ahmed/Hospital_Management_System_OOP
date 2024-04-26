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
            lblName.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.MediumPurple;
            lblName.Location = new Point(27, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(327, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Front Desk Dashboard";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGray;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(102, 255);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(282, 53);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add a New Patient";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(395, 652);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Log Out";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Front_Desk_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 696);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Front_Desk_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
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