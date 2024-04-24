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
            SuspendLayout();
            // 
            // bxUserName
            // 
            bxUserName.Anchor = AnchorStyles.Top;
            bxUserName.Location = new Point(438, 157);
            bxUserName.Margin = new Padding(3, 4, 3, 4);
            bxUserName.Name = "bxUserName";
            bxUserName.Size = new Size(138, 27);
            bxUserName.TabIndex = 0;
            // 
            // bxPassword
            // 
            bxPassword.Anchor = AnchorStyles.Top;
            bxPassword.Location = new Point(438, 233);
            bxPassword.Margin = new Padding(3, 4, 3, 4);
            bxPassword.Name = "bxPassword";
            bxPassword.Size = new Size(138, 27);
            bxPassword.TabIndex = 2;
            bxPassword.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(326, 160);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(326, 240);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Location = new Point(457, 296);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // bxRole
            // 
            bxRole.Anchor = AnchorStyles.Top;
            bxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            bxRole.FormattingEnabled = true;
            bxRole.Items.AddRange(new object[] { "Admin", "Front Desk", "Patient" });
            bxRole.Location = new Point(438, 85);
            bxRole.Margin = new Padding(3, 4, 3, 4);
            bxRole.Name = "bxRole";
            bxRole.Size = new Size(138, 28);
            bxRole.TabIndex = 7;
            bxRole.SelectedIndexChanged += bxRole_SelectedIndexChanged;
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top;
            lblRole.AutoSize = true;
            lblRole.Location = new Point(326, 85);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top;
            btnRegister.Location = new Point(385, 366);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(229, 31);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Or Register New User";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRegister);
            Controls.Add(lblRole);
            Controls.Add(bxRole);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(bxPassword);
            Controls.Add(bxUserName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login_Page";
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
    }
}
