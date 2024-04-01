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
    public partial class Patient_Dashboard : Form
    {
        public Patient_Dashboard()
        {
            InitializeComponent();
        }

        private void Patient_Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Update_Info update_Info = new Patient_Update_Info();
            update_Info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_FollowUp followUp = new Patient_FollowUp();
            followUp.Show();
        }
    }
}
