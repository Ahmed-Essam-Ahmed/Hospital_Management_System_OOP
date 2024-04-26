namespace Hospital_Managment_System_OOP
{
    partial class Register_Page
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
            label3 = new Label();
            bxFirstName = new TextBox();
            bxLastName = new TextBox();
            bxUserName = new TextBox();
            bxPassword = new TextBox();
            btnRegister = new Button();
            bxRole = new ComboBox();
            btnBack = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 347);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // bxFirstName
            // 
            bxFirstName.BackColor = SystemColors.Menu;
            bxFirstName.BorderStyle = BorderStyle.None;
            bxFirstName.Font = new Font("Rockwell", 13.8F);
            bxFirstName.Location = new Point(110, 234);
            bxFirstName.Margin = new Padding(3, 4, 3, 4);
            bxFirstName.Name = "bxFirstName";
            bxFirstName.Size = new Size(245, 28);
            bxFirstName.TabIndex = 4;
            // 
            // bxLastName
            // 
            bxLastName.BackColor = SystemColors.Menu;
            bxLastName.BorderStyle = BorderStyle.None;
            bxLastName.Font = new Font("Rockwell", 13.8F);
            bxLastName.Location = new Point(110, 322);
            bxLastName.Margin = new Padding(3, 4, 3, 4);
            bxLastName.Name = "bxLastName";
            bxLastName.Size = new Size(245, 28);
            bxLastName.TabIndex = 5;
            // 
            // bxUserName
            // 
            bxUserName.BackColor = SystemColors.Menu;
            bxUserName.BorderStyle = BorderStyle.None;
            bxUserName.Font = new Font("Rockwell", 13.8F);
            bxUserName.Location = new Point(110, 401);
            bxUserName.Margin = new Padding(3, 4, 3, 4);
            bxUserName.Name = "bxUserName";
            bxUserName.Size = new Size(245, 28);
            bxUserName.TabIndex = 6;
            // 
            // bxPassword
            // 
            bxPassword.BackColor = SystemColors.Menu;
            bxPassword.BorderStyle = BorderStyle.None;
            bxPassword.Font = new Font("Rockwell", 13.8F);
            bxPassword.Location = new Point(110, 486);
            bxPassword.Margin = new Padding(3, 4, 3, 4);
            bxPassword.Name = "bxPassword";
            bxPassword.Size = new Size(245, 28);
            bxPassword.TabIndex = 7;
            bxPassword.TextChanged += bxPassword_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumPurple;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(128, 540);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(198, 47);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // bxRole
            // 
            bxRole.BackColor = SystemColors.Menu;
            bxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            bxRole.FlatStyle = FlatStyle.Flat;
            bxRole.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxRole.FormattingEnabled = true;
            bxRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            bxRole.Location = new Point(110, 139);
            bxRole.Margin = new Padding(3, 4, 3, 4);
            bxRole.Name = "bxRole";
            bxRole.Size = new Size(245, 34);
            bxRole.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 605);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumPurple;
            label7.Location = new Point(144, 50);
            label7.Name = "label7";
            label7.Size = new Size(182, 38);
            label7.TabIndex = 13;
            label7.Text = "Get Started";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(110, 99);
            label6.Name = "label6";
            label6.Size = new Size(123, 22);
            label6.TabIndex = 14;
            label6.Text = "Choose Role";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(110, 192);
            label5.Name = "label5";
            label5.Size = new Size(108, 22);
            label5.TabIndex = 15;
            label5.Text = "First Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(110, 285);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 16;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(110, 375);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 17;
            label2.Text = "Create Username";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.Location = new Point(110, 449);
            label8.Name = "label8";
            label8.Size = new Size(164, 22);
            label8.TabIndex = 18;
            label8.Text = "Create Password";
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(475, 649);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(bxRole);
            Controls.Add(btnRegister);
            Controls.Add(bxPassword);
            Controls.Add(bxUserName);
            Controls.Add(bxLastName);
            Controls.Add(bxFirstName);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox bxFirstName;
        private TextBox bxLastName;
        private TextBox bxUserName;
        private TextBox bxPassword;
        private Button btnRegister;
        private ComboBox bxRole;
        private Button btnBack;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label8;
    }
}