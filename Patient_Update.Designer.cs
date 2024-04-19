namespace Hospital_Managment_System_OOP
{
    partial class Patient_Update
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
            LabelCity = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnDone = new Button();
            btnBack = new Button();
            btnHome = new Button();
            bxPHN = new TextBox();
            bxPostal = new TextBox();
            bxPhone = new TextBox();
            bxAge = new TextBox();
            bxCity = new TextBox();
            bxAddress = new TextBox();
            bxCountry = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 312);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Personal Health Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 187);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 249);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Postal Code";
            // 
            // LabelCity
            // 
            LabelCity.AutoSize = true;
            LabelCity.Location = new Point(428, 249);
            LabelCity.Name = "LabelCity";
            LabelCity.Size = new Size(34, 20);
            LabelCity.TabIndex = 3;
            LabelCity.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 187);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 124);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(140, 26);
            label7.Name = "label7";
            label7.Size = new Size(368, 54);
            label7.TabIndex = 6;
            label7.Text = "Patient Update Info";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 115);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 7;
            label8.Text = "Age";
            label8.Click += label8_Click;
            // 
            // btnDone
            // 
            btnDone.Location = new Point(414, 312);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(94, 29);
            btnDone.TabIndex = 8;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(590, 409);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(198, 29);
            btnHome.TabIndex = 10;
            btnHome.Text = "Return to Homepage";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // bxPHN
            // 
            bxPHN.Location = new Point(199, 312);
            bxPHN.Name = "bxPHN";
            bxPHN.Size = new Size(125, 27);
            bxPHN.TabIndex = 11;
            // 
            // bxPostal
            // 
            bxPostal.Location = new Point(199, 249);
            bxPostal.Name = "bxPostal";
            bxPostal.Size = new Size(125, 27);
            bxPostal.TabIndex = 12;
            // 
            // bxPhone
            // 
            bxPhone.Location = new Point(199, 187);
            bxPhone.Name = "bxPhone";
            bxPhone.Size = new Size(125, 27);
            bxPhone.TabIndex = 13;
            // 
            // bxAge
            // 
            bxAge.Location = new Point(199, 112);
            bxAge.Name = "bxAge";
            bxAge.Size = new Size(125, 27);
            bxAge.TabIndex = 14;
            // 
            // bxCity
            // 
            bxCity.Location = new Point(526, 246);
            bxCity.Name = "bxCity";
            bxCity.Size = new Size(125, 27);
            bxCity.TabIndex = 15;
            // 
            // bxAddress
            // 
            bxAddress.Location = new Point(526, 180);
            bxAddress.Name = "bxAddress";
            bxAddress.Size = new Size(125, 27);
            bxAddress.TabIndex = 16;
            // 
            // bxCountry
            // 
            bxCountry.FormattingEnabled = true;
            bxCountry.Location = new Point(526, 115);
            bxCountry.Name = "bxCountry";
            bxCountry.Size = new Size(151, 28);
            bxCountry.TabIndex = 17;
            // 
            // Patient_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bxCountry);
            Controls.Add(bxAddress);
            Controls.Add(bxCity);
            Controls.Add(bxAge);
            Controls.Add(bxPhone);
            Controls.Add(bxPostal);
            Controls.Add(bxPHN);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(btnDone);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LabelCity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Patient_Update";
            Text = "Patient_Update";
            Load += Patient_Update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label LabelCity;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnDone;
        private Button btnBack;
        private Button btnHome;
        private TextBox bxPHN;
        private TextBox bxPostal;
        private TextBox bxPhone;
        private TextBox bxAge;
        private TextBox bxCity;
        private TextBox bxAddress;
        private ComboBox bxCountry;
    }
}