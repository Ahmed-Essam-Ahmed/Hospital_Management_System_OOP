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
            bxDelete = new TextBox();
            button1 = new Button();
            btnHomepage = new Button();
            btnBack = new Button();
            TablePatient = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TablePatient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 0;
            label1.Text = "Delete a Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 299);
            label2.Name = "label2";
            label2.Size = new Size(185, 15);
            label2.TabIndex = 1;
            label2.Text = "Patient to Delete(Using Password)";
            label2.Click += label2_Click;
            // 
            // bxDelete
            // 
            bxDelete.Location = new Point(272, 296);
            bxDelete.Name = "bxDelete";
            bxDelete.Size = new Size(100, 23);
            bxDelete.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(432, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.Location = new Point(616, 415);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(172, 23);
            btnHomepage.TabIndex = 4;
            btnHomepage.Text = "Return to Homepage";
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
            // TablePatient
            // 
            TablePatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablePatient.Location = new Point(99, 70);
            TablePatient.Name = "TablePatient";
            TablePatient.Size = new Size(567, 196);
            TablePatient.TabIndex = 6;
            // 
            // Admin_Delete_Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TablePatient);
            Controls.Add(btnBack);
            Controls.Add(btnHomepage);
            Controls.Add(button1);
            Controls.Add(bxDelete);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Delete_Patient";
            Text = "Admin_Delete_Patient";
            Load += Admin_Delete_Patient_Load;
            ((System.ComponentModel.ISupportInitialize)TablePatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox bxDelete;
        private Button button1;
        private Button btnHomepage;
        private Button btnBack;
        private DataGridView TablePatient;
    }
}