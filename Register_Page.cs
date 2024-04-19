using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Managment_System_OOP
{
    public partial class Register_Page : Form
    {

        public Register_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (bxRole.SelectedItem != null)
            {
                string selectedItem = bxRole.SelectedItem.ToString();

                if (selectedItem == "Admin")
                {
                    string firstName = bxFirstName.Text;
                    string lastName = bxLastName.Text;
                    string username = bxUserName.Text;
                    string password = bxPassword.Text;
                    
                    Admin currentAdmin=new Admin(firstName, lastName, username, password);
                    currentAdmin.Register();

                   
                    this.Hide();
                    Login_Page login_Page = new Login_Page();
                    login_Page.Show();

                }
                else if (selectedItem == "Front Desk")
                {
                    string firstName = bxFirstName.Text;
                    string lastName = bxLastName.Text;
                    string username = bxUserName.Text;
                    string password = bxPassword.Text;

                    FrontDesk currentFrontDesk = new FrontDesk(firstName, lastName, username, password);
                    currentFrontDesk.Register();

                    this.Hide();
                    Login_Page login_Page = new Login_Page();
                    login_Page.Show();
                }

                else
                {
                    MessageBox.Show("Choose Role");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page Login_Page = new Login_Page();
            Login_Page.Show();

        }
    }
}
