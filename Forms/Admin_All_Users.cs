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
    public partial class Admin_All_Users : Form
    {
        public Admin_All_Users()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void Admin_All_Users_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.AllUsersAccounts(AdminGrid);

            FrontDesk frontDesk = new FrontDesk();
            frontDesk.AllUsersAccounts(FrontDeskGrid);

            Patient patient = new Patient();
            patient.AllUsersAccounts(PatientGrid);

        }
    }
}
    