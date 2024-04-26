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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            label1.Font = new Font("Rockwell", 18F);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(232, 35);
            label1.TabIndex = 0;
            label1.Text = "Delete a Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 399);
            label2.Name = "label2";
            label2.Size = new Size(232, 20);
            label2.TabIndex = 1;
            label2.Text = "Patient to Delete(Using Password)";
            label2.Click += label2_Click;
            // 
            // bxDelete
            // 
            bxDelete.Location = new Point(311, 395);
            bxDelete.Margin = new Padding(3, 4, 3, 4);
            bxDelete.Name = "bxDelete";
            bxDelete.Size = new Size(114, 27);
            bxDelete.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 10.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(494, 395);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = Color.Silver;
            btnHomepage.FlatAppearance.BorderSize = 0;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Rockwell", 10.8F);
            btnHomepage.ForeColor = Color.White;
            btnHomepage.Location = new Point(646, 556);
            btnHomepage.Margin = new Padding(3, 4, 3, 4);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(86, 31);
            btnHomepage.TabIndex = 4;
            btnHomepage.Text = "Log Out";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Rockwell", 10.8F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 556);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 31);
            btnBack.TabIndex = 5;
            btnBack.Text = "Homepage";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // TablePatient
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            TablePatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            TablePatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TablePatient.BackgroundColor = Color.Silver;
            TablePatient.BorderStyle = BorderStyle.None;
            TablePatient.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TablePatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TablePatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablePatient.Location = new Point(61, 113);
            TablePatient.Margin = new Padding(3, 4, 3, 4);
            TablePatient.Name = "TablePatient";
            TablePatient.ReadOnly = true;
            TablePatient.RowHeadersWidth = 51;
            TablePatient.Size = new Size(648, 261);
            TablePatient.TabIndex = 6;
            // 
            // Admin_Delete_Patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 600);
            Controls.Add(TablePatient);
            Controls.Add(btnBack);
            Controls.Add(btnHomepage);
            Controls.Add(button1);
            Controls.Add(bxDelete);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Delete_Patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
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