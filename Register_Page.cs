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

                    // Write user information to a text file
                    using (StreamWriter writer = new StreamWriter("AdminData.txt", true))
                    {
                        writer.WriteLine($"{firstName},{lastName},{username},{password}");
                    }

                    MessageBox.Show("Registration Successful!");
                }
                else if (selectedItem == "Front Desk")
                {
                   
                }
                
                else
                {
                    MessageBox.Show("Choose Role");
                }
            }
        }
    }
}
