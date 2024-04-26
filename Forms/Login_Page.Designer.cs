namespace Hospital_Managment_System_OOP
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bxUserName = new TextBox();
            bxPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            bxRole = new ComboBox();
            lblRole = new Label();
            btnRegister = new Button();
            label2 = new Label();
            label4 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // bxUserName
            // 
            bxUserName.Anchor = AnchorStyles.Top;
            bxUserName.BackColor = SystemColors.Menu;
            bxUserName.BorderStyle = BorderStyle.None;
            bxUserName.Font = new Font("Rockwell", 13.8F);
            bxUserName.Location = new Point(121, 299);
            bxUserName.Margin = new Padding(3, 4, 3, 4);
            bxUserName.Name = "bxUserName";
            bxUserName.Size = new Size(245, 28);
            bxUserName.TabIndex = 0;
            // 
            // bxPassword
            // 
            bxPassword.Anchor = AnchorStyles.Top;
            bxPassword.BackColor = SystemColors.Menu;
            bxPassword.BorderStyle = BorderStyle.None;
            bxPassword.Font = new Font("Rockwell", 13.8F);
            bxPassword.Location = new Point(121, 371);
            bxPassword.Margin = new Padding(3, 4, 3, 4);
            bxPassword.Name = "bxPassword";
            bxPassword.Size = new Size(245, 28);
            bxPassword.TabIndex = 2;
            bxPassword.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(121, 263);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(121, 348);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.MediumPurple;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(121, 466);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(245, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // bxRole
            // 
            bxRole.Anchor = AnchorStyles.Top;
            bxRole.BackColor = SystemColors.Menu;
            bxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            bxRole.FlatStyle = FlatStyle.Flat;
            bxRole.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxRole.FormattingEnabled = true;
            bxRole.Items.AddRange(new object[] { "Admin", "Front Desk", "Patient" });
            bxRole.Location = new Point(121, 201);
            bxRole.Margin = new Padding(3, 4, 3, 4);
            bxRole.Name = "bxRole";
            bxRole.Size = new Size(245, 34);
            bxRole.TabIndex = 7;
            bxRole.SelectedIndexChanged += bxRole_SelectedIndexChanged;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Rockwell", 12F);
            lblRole.ForeColor = SystemColors.ButtonShadow;
            lblRole.Location = new Point(121, 166);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(50, 22);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top;
            btnRegister.BackColor = Color.Silver;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(121, 568);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(245, 39);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register Now";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(82, 89);
            label2.Name = "label2";
            label2.Size = new Size(346, 38);
            label2.TabIndex = 12;
            label2.Text = "Hospital Management";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 544);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 13;
            label4.Text = "New Here?";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DimGray;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Rockwell", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(196, 652);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 32);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 696);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(lblRole);
            Controls.Add(bxRole);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bxPassword);
            Controls.Add(bxUserName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bxUserName;
        private TextBox bxPassword;
        private Label label1;
        private Label label3;
        private Button btnLogin;
        private ComboBox bxRole;
        private Label lblRole;
        private Button btnRegister;
        private Label label2;
        private Label label4;
        private Button btnExit;
    }
}
