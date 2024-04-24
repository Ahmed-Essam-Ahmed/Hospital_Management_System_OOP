using Microsoft.IdentityModel.Tokens;
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
            if (string.IsNullOrEmpty(bxRole.Text) || string.IsNullOrEmpty(bxFirstName.Text) ||
                string.IsNullOrEmpty(bxLastName.Text) || string.IsNullOrEmpty(bxUserName.Text) || string.IsNullOrEmpty(bxPassword.Text))
            {
                MessageBox.Show("Complete All Fields!");
            }
           
            else
            {
                string selectedItem = bxRole.SelectedItem.ToString();

                string firstName = bxFirstName.Text;
                string lastName = bxLastName.Text;

                if (!IsValidName(firstName) || !IsValidName(lastName))
                {
                    MessageBox.Show("Invalid first name or last name.");
                    return;
                }

                if (selectedItem == "Admin")
                {
                    string username = bxUserName.Text;
                    string password = bxPassword.Text;

                    Admin currentAdmin = new Admin(firstName, lastName, username, password);
                    currentAdmin.Register();

                    this.Hide();
                    Login_Page login_Page = new Login_Page();
                    login_Page.Show();

                }
                else if (selectedItem == "Front Desk")
                {
                    string username = bxUserName.Text;
                    string password = bxPassword.Text;
                    FrontDesk currentFrontDesk = new FrontDesk(firstName, lastName, username, password);
                    currentFrontDesk.Register();

                    this.Hide();
                    Login_Page login_Page = new Login_Page();
                    login_Page.Show();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page Login_Page = new Login_Page();
            Login_Page.Show();
        }

        private void bxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidName(string name)
        {
            foreach(char c in name)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }  
    }
}
