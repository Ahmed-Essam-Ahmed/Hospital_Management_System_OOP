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
            label1.Location = new Point(107, 112);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 157);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 210);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Create Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 254);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Create A Password";
            // 
            // bxFirstName
            // 
            bxFirstName.Location = new Point(225, 104);
            bxFirstName.Name = "bxFirstName";
            bxFirstName.Size = new Size(100, 23);
            bxFirstName.TabIndex = 4;
            // 
            // bxLastName
            // 
            bxLastName.Location = new Point(239, 154);
            bxLastName.Name = "bxLastName";
            bxLastName.Size = new Size(100, 23);
            bxLastName.TabIndex = 5;
            // 
            // bxUserName
            // 
            bxUserName.Location = new Point(239, 204);
            bxUserName.Name = "bxUserName";
            bxUserName.Size = new Size(100, 23);
            bxUserName.TabIndex = 6;
            // 
            // bxPassword
            // 
            bxPassword.Location = new Point(239, 251);
            bxPassword.Name = "bxPassword";
            bxPassword.Size = new Size(100, 23);
            bxPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(250, 307);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // bxRole
            // 
            bxRole.FormattingEnabled = true;
            bxRole.Items.AddRange(new object[] { "Admin", "Front Desk" });
            bxRole.Location = new Point(225, 46);
            bxRole.Name = "bxRole";
            bxRole.Size = new Size(121, 23);
            bxRole.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 54);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 10;
            label5.Text = "Choose Role";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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