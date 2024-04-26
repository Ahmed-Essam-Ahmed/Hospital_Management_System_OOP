namespace Hospital_Managment_System_OOP
{
    partial class Admin_AddBeds
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
            lblBedsAvailable = new Label();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            btnHome = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(37, 63);
            label1.Name = "label1";
            label1.Size = new Size(294, 35);
            label1.TabIndex = 0;
            label1.Text = "Admin Adding Beds";
            // 
            // lblBedsAvailable
            // 
            lblBedsAvailable.AutoSize = true;
            lblBedsAvailable.FlatStyle = FlatStyle.Flat;
            lblBedsAvailable.Font = new Font("Rockwell", 12F);
            lblBedsAvailable.ForeColor = SystemColors.ButtonShadow;
            lblBedsAvailable.Location = new Point(192, 332);
            lblBedsAvailable.Name = "lblBedsAvailable";
            lblBedsAvailable.Size = new Size(68, 22);
            lblBedsAvailable.TabIndex = 1;
            lblBedsAvailable.Text = "label2";
            lblBedsAvailable.Click += lblBedsAvailable_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Rockwell", 10.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(305, 325);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Remove ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.Location = new Point(37, 240);
            label3.Name = "label3";
            label3.Size = new Size(149, 22);
            label3.TabIndex = 4;
            label3.Text = "Beds Available";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 10.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(37, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Silver;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Rockwell", 10.8F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(395, 653);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 31);
            btnHome.TabIndex = 6;
            btnHome.Text = "Log Out";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 653);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 31);
            btnBack.TabIndex = 7;
            btnBack.Text = "Homepage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Admin_AddBeds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 696);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(lblBedsAvailable);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_AddBeds";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_AddBeds";
            Load += Admin_AddBeds_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBedsAvailable;
        private Button button2;
        private Label label3;
        private Button button1;
        private Button btnHome;
        private Button btnBack;
    }
}