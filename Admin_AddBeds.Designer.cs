namespace Hospital_Managment_System_OOP
{
    partial class Admin_AddBeds
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
            lblBedsAvailable = new Label();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 57);
            label1.Name = "label1";
            label1.Size = new Size(378, 54);
            label1.TabIndex = 0;
            label1.Text = "Admin Adding Beds";
            // 
            // lblBedsAvailable
            // 
            lblBedsAvailable.AutoSize = true;
            lblBedsAvailable.Location = new Point(258, 204);
            lblBedsAvailable.Name = "lblBedsAvailable";
            lblBedsAvailable.Size = new Size(50, 20);
            lblBedsAvailable.TabIndex = 1;
            lblBedsAvailable.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(445, 200);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Remove ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 204);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 4;
            label3.Text = "Beds Availale";
            // 
            // button1
            // 
            button1.Location = new Point(334, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Admin_AddBeds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(lblBedsAvailable);
            Controls.Add(label1);
            Name = "Admin_AddBeds";
            Text = "Admin_AddBeds";
            Load += Admin_AddBeds_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBedsAvailable;
        private Button button2;
        private Label label3;
        private Button button1;
    }
}