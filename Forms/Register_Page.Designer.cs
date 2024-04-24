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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bxFirstName = new TextBox();
            bxLastName = new TextBox();
            bxUserName = new TextBox();
            bxPassword = new TextBox();
            btnRegister = new Button();
            bxRole = new ComboBox();
            label5 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 149);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 209);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 280);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Create Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 339);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 3;
            label4.Text = "Create A Password";
            // 
            // bxFirstName
            // 
            bxFirstName.Location = new Point(257, 139);
            bxFirstName.Margin = new Padding(3, 4, 3, 4);
            bxFirstName.Name = "bxFirstName";
            bxFirstName.Size = new Size(114, 27);
            bxFirstName.TabIndex = 4;
            // 
            // bxLastName
            // 
            bxLastName.Location = new Point(273, 205);
            bxLastName.Margin = new Padding(3, 4, 3, 4);
            bxLastName.Name = "bxLastName";
            bxLastName.Size = new Size(114, 27);
            bxLastName.TabIndex = 5;
            // 
            // bxUserName
            // 
            bxUserName.Location = new Point(273, 272);
            bxUserName.Margin = new Padding(3, 4, 3, 4);
            bxUserName.Name = "bxUserName";
            bxUserName.Size = new Size(114, 27);
            bxUserName.TabIndex = 6;
            // 
            // bxPassword
            // 
            bxPassword.Location = new Point(273, 335);
            bxPassword.Margin = new Padding(3, 4, 3, 4);
            bxPassword.Name = "bxPassword";
            bxPassword.Size = new Size(114, 27);
            bxPassword.TabIndex = 7;
            bxPassword.TextChanged += bxPassword_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(286, 409);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 31);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // bxRole
            // 
            bxRole.FormattingEnabled = true;
            bxRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            bxRole.Location = new Point(257, 61);
            bxRole.Margin = new Padding(3, 4, 3, 4);
            bxRole.Name = "bxRole";
            bxRole.Size = new Size(138, 28);
            bxRole.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 72);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 10;
            label5.Text = "Choose Role";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 553);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(bxRole);
            Controls.Add(btnRegister);
            Controls.Add(bxPassword);
            Controls.Add(bxUserName);
            Controls.Add(bxLastName);
            Controls.Add(bxFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register_Page";
            Text = "Register_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox bxFirstName;
        private TextBox bxLastName;
        private TextBox bxUserName;
        private TextBox bxPassword;
        private Button btnRegister;
        private ComboBox bxRole;
        private Label label5;
        private Button btnBack;
    }
}