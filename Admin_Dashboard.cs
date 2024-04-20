using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Managment_System_OOP
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void btnDelete_Patient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Delete_Patient admin_Delete_Patient = new Admin_Delete_Patient();
            admin_Delete_Patient.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_AddBeds admin_AddBeds = new Admin_AddBeds();
            admin_AddBeds.Show();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("AdminData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[2] == CurrentUser.UserName)
                {
                    CurrentUser.FirstName = parts[0];
                    CurrentUser.LastName = parts[1];
                    lblName.Text = ($"Welcome  {parts[0] + ' ' + parts[1]}");

                }
            }
        }
    }
}
