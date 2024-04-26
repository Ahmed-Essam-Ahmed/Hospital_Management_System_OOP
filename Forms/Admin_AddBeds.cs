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
    public partial class Admin_AddBeds : Form
    {
        public Admin_AddBeds()
        {
            InitializeComponent();

            {
                string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

                string lastLine = lines[lines.Length - 1];
                string[] parts = lastLine.Split('|');
                string currentBeds = parts[1];
                lblBedsAvailable.Text = currentBeds;

            }

        }

        private void Admin_AddBeds_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            button2.Enabled = true;
            Admin currentAdmin = new Admin();
            currentAdmin.AddBeds();
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split('|');
            string currentBeds = parts[1];
            lblBedsAvailable.Text = currentBeds;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblBedsAvailable.Text) == 1)
            {
                Admin currentAdmin = new Admin();
                currentAdmin.RemoveBeds();
                string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

                string lastLine = lines[lines.Length - 1];
                string[] parts = lastLine.Split('|');
                string currentBeds = parts[1];
                lblBedsAvailable.Text = currentBeds;
                button2.Enabled = false;
            }
            else
            {

                Admin currentAdmin = new Admin();
                currentAdmin.RemoveBeds();
                string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

                string lastLine = lines[lines.Length - 1];
                string[] parts = lastLine.Split('|');
                string currentBeds = parts[1];
                lblBedsAvailable.Text = currentBeds;


            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            this.Hide();
            admin_Dashboard.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void lblBedsAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
