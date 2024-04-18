namespace Hospital_Managment_System_OOP
{
    partial class Admin_Delete_Patient
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
            textBox1 = new TextBox();
            button1 = new Button();
            btnHomepage = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 65);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 0;
            label1.Text = "Delete a Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 229);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient ID to Delete";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(337, 229);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnHomepage
            // 
            btnHomepage.Location = new Point(616, 415);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(172, 23);
            btnHomepage.TabIndex = 4;
            btnHomepage.Text = "Return to Homepagr";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Admin_Delete_Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnHomepage);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Delete_Patient";
            Text = "Admin_Delete_Patient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button btnHomepage;
        private Button btnBack;
    }
}