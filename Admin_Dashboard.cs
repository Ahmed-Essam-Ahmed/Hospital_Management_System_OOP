using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
