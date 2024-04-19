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
                string[] parts = lastLine.Split(',');
                string currentBeds = parts[1];
                lblBedsAvailable.Text = currentBeds;

            }

        }

        private void Admin_AddBeds_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin currentAdmin = new Admin();
            currentAdmin.AddBeds();
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(',');
            string currentBeds = parts[1];
            lblBedsAvailable.Text = currentBeds;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin currentAdmin = new Admin();
            currentAdmin.RemoveBeds();
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(',');
            string currentBeds = parts[1];
            lblBedsAvailable.Text = currentBeds;
        }
    }
}
