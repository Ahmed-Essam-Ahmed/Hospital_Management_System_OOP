namespace Hospital_Managment_System_OOP
{
    partial class Front_Desk_Adding_Patient
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
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnDone = new Button();
            btnHome = new Button();
            btnBack = new Button();
            bxCity = new TextBox();
            bxFirstName = new TextBox();
            bxLastName = new TextBox();
            bxAge = new TextBox();
            bxPHN = new TextBox();
            bxPostal = new TextBox();
            bxPhoneNum = new TextBox();
            lblPhone = new Label();
            bxCountry = new ComboBox();
            bxAddress = new RichTextBox();
            bxDisease = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 0;
            label1.Text = "Adding a New Patient";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(427, 108);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(75, 108);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(427, 184);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F);
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(427, 312);
            label5.Name = "label5";
            label5.Size = new Size(48, 22);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(427, 375);
            label6.Name = "label6";
            label6.Size = new Size(187, 22);
            label6.TabIndex = 5;
            label6.Text = "Prescribed Disease";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 12F);
            label8.ForeColor = SystemColors.ButtonShadow;
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(75, 184);
            label8.Name = "label8";
            label8.Size = new Size(104, 22);
            label8.TabIndex = 7;
            label8.Text = "Last Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 12F);
            label9.ForeColor = SystemColors.ButtonShadow;
            label9.ImageAlign = ContentAlignment.MiddleRight;
            label9.Location = new Point(75, 312);
            label9.Name = "label9";
            label9.Size = new Size(48, 22);
            label9.TabIndex = 8;
            label9.Text = "Age";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 12F);
            label10.ForeColor = SystemColors.ButtonShadow;
            label10.ImageAlign = ContentAlignment.MiddleRight;
            label10.Location = new Point(75, 375);
            label10.Name = "label10";
            label10.Size = new Size(231, 22);
            label10.TabIndex = 9;
            label10.Text = "Personal Health Number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 12F);
            label11.ForeColor = SystemColors.ButtonShadow;
            label11.ImageAlign = ContentAlignment.MiddleRight;
            label11.Location = new Point(75, 438);
            label11.Name = "label11";
            label11.Size = new Size(119, 22);
            label11.TabIndex = 10;
            label11.Text = "Postal Code";
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.MediumPurple;
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDone.ForeColor = Color.White;
            btnDone.Location = new Point(427, 462);
            btnDone.Margin = new Padding(3, 4, 3, 4);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(97, 41);
            btnDone.TabIndex = 11;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += button1_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Silver;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Rockwell", 10.8F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(646, 556);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 31);
            btnHome.TabIndex = 12;
            btnHome.Text = "Log Out";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += button2_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 556);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 31);
            btnBack.TabIndex = 13;
            btnBack.Text = "Homepage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // bxCity
            // 
            bxCity.BackColor = SystemColors.Menu;
            bxCity.BorderStyle = BorderStyle.None;
            bxCity.Font = new Font("Rockwell", 13.8F);
            bxCity.Location = new Point(427, 343);
            bxCity.Margin = new Padding(3, 4, 3, 4);
            bxCity.Name = "bxCity";
            bxCity.Size = new Size(245, 28);
            bxCity.TabIndex = 16;
            // 
            // bxFirstName
            // 
            bxFirstName.BackColor = SystemColors.Menu;
            bxFirstName.BorderStyle = BorderStyle.None;
            bxFirstName.Font = new Font("Rockwell", 13.8F);
            bxFirstName.Location = new Point(75, 139);
            bxFirstName.Margin = new Padding(3, 4, 3, 4);
            bxFirstName.Name = "bxFirstName";
            bxFirstName.Size = new Size(245, 28);
            bxFirstName.TabIndex = 19;
            // 
            // bxLastName
            // 
            bxLastName.BackColor = SystemColors.Menu;
            bxLastName.BorderStyle = BorderStyle.None;
            bxLastName.Font = new Font("Rockwell", 13.8F);
            bxLastName.Location = new Point(75, 208);
            bxLastName.Margin = new Padding(3, 4, 3, 4);
            bxLastName.Name = "bxLastName";
            bxLastName.Size = new Size(245, 28);
            bxLastName.TabIndex = 20;
            // 
            // bxAge
            // 
            bxAge.BackColor = SystemColors.Menu;
            bxAge.BorderStyle = BorderStyle.None;
            bxAge.Font = new Font("Rockwell", 13.8F);
            bxAge.Location = new Point(75, 336);
            bxAge.Margin = new Padding(3, 4, 3, 4);
            bxAge.Name = "bxAge";
            bxAge.Size = new Size(245, 28);
            bxAge.TabIndex = 21;
            // 
            // bxPHN
            // 
            bxPHN.BackColor = SystemColors.Menu;
            bxPHN.BorderStyle = BorderStyle.None;
            bxPHN.Font = new Font("Rockwell", 13.8F);
            bxPHN.Location = new Point(75, 399);
            bxPHN.Margin = new Padding(3, 4, 3, 4);
            bxPHN.Name = "bxPHN";
            bxPHN.Size = new Size(245, 28);
            bxPHN.TabIndex = 22;
            // 
            // bxPostal
            // 
            bxPostal.BackColor = SystemColors.Menu;
            bxPostal.BorderStyle = BorderStyle.None;
            bxPostal.Font = new Font("Rockwell", 13.8F);
            bxPostal.Location = new Point(75, 462);
            bxPostal.Margin = new Padding(3, 4, 3, 4);
            bxPostal.Name = "bxPostal";
            bxPostal.Size = new Size(245, 28);
            bxPostal.TabIndex = 23;
            // 
            // bxPhoneNum
            // 
            bxPhoneNum.BackColor = SystemColors.Menu;
            bxPhoneNum.BorderStyle = BorderStyle.None;
            bxPhoneNum.Font = new Font("Rockwell", 13.8F);
            bxPhoneNum.Location = new Point(75, 271);
            bxPhoneNum.Margin = new Padding(3, 4, 3, 4);
            bxPhoneNum.Name = "bxPhoneNum";
            bxPhoneNum.Size = new Size(245, 28);
            bxPhoneNum.TabIndex = 24;
            bxPhoneNum.TextChanged += textBox5_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Rockwell", 12F);
            lblPhone.ForeColor = SystemColors.ButtonShadow;
            lblPhone.ImageAlign = ContentAlignment.MiddleRight;
            lblPhone.Location = new Point(75, 247);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(144, 22);
            lblPhone.TabIndex = 25;
            lblPhone.Text = "Phone Number";
            lblPhone.Click += lblPhone_Click;
            // 
            // bxCountry
            // 
            bxCountry.BackColor = SystemColors.Menu;
            bxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            bxCountry.FlatStyle = FlatStyle.Flat;
            bxCountry.Font = new Font("Rockwell", 13.8F);
            bxCountry.ForeColor = SystemColors.ControlText;
            bxCountry.FormattingEnabled = true;
            bxCountry.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia, Federated States of", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            bxCountry.Location = new Point(429, 136);
            bxCountry.Margin = new Padding(3, 4, 3, 4);
            bxCountry.Name = "bxCountry";
            bxCountry.Size = new Size(247, 34);
            bxCountry.TabIndex = 26;
            // 
            // bxAddress
            // 
            bxAddress.BackColor = SystemColors.Menu;
            bxAddress.BorderStyle = BorderStyle.None;
            bxAddress.Font = new Font("Rockwell", 13.8F);
            bxAddress.Location = new Point(427, 208);
            bxAddress.Margin = new Padding(3, 4, 3, 4);
            bxAddress.Name = "bxAddress";
            bxAddress.Size = new Size(247, 85);
            bxAddress.TabIndex = 27;
            bxAddress.Text = "";
            // 
            // bxDisease
            // 
            bxDisease.BackColor = SystemColors.Menu;
            bxDisease.DropDownStyle = ComboBoxStyle.DropDownList;
            bxDisease.FlatStyle = FlatStyle.Flat;
            bxDisease.Font = new Font("Rockwell", 13.8F);
            bxDisease.ForeColor = SystemColors.Menu;
            bxDisease.FormattingEnabled = true;
            bxDisease.Items.AddRange(new object[] { "Chickenpox", "Common cold", "COVID-19", "Influenza", "Monkeypox" });
            bxDisease.Location = new Point(427, 401);
            bxDisease.Margin = new Padding(3, 4, 3, 4);
            bxDisease.Name = "bxDisease";
            bxDisease.Size = new Size(257, 34);
            bxDisease.TabIndex = 28;
            // 
            // Front_Desk_Adding_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 600);
            Controls.Add(bxDisease);
            Controls.Add(bxAddress);
            Controls.Add(bxCountry);
            Controls.Add(lblPhone);
            Controls.Add(bxPhoneNum);
            Controls.Add(bxPostal);
            Controls.Add(bxPHN);
            Controls.Add(bxAge);
            Controls.Add(bxLastName);
            Controls.Add(bxFirstName);
            Controls.Add(bxCity);
            Controls.Add(btnBack);
            Controls.Add(btnHome);
            Controls.Add(btnDone);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Front_Desk_Adding_Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Front_Desk_Adding_Patient";
            Load += Front_Desk_Adding_Patient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnDone;
        private Button btnHome;
        private Button btnBack;
        private TextBox bxCity;
        private TextBox bxFirstName;
        private TextBox bxLastName;
        private TextBox bxAge;
        private TextBox bxPHN;
        private TextBox bxPostal;
        private TextBox bxPhoneNum;
        private Label lblPhone;
        private ComboBox bxCountry;
        private RichTextBox bxAddress;
        private ComboBox bxDisease;
    }
}