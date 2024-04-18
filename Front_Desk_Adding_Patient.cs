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
    public partial class Front_Desk_Adding_Patient : Form
    {
        public Front_Desk_Adding_Patient()
        {
            InitializeComponent();
        }

        private void Front_Desk_Adding_Patient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Front_Desk_Dashboard front_Desk_Dashboard=new Front_Desk_Dashboard();
            front_Desk_Dashboard.Show();
        }
    }
}
