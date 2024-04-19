using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Admin_Delete_Patient : Form
    {
        public Admin_Delete_Patient()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Delete_Patient_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            TablePatient.DataSource = table;

            string filePath = "PatientData.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    string username = parts[10];
                    string password = parts[11];
                    table.Rows.Add(username, password);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "PatientData.txt";
            string[] lines = File.ReadAllLines(filePath);

            bool deleted = false; // Flag to indicate if any patient was deleted

            // Open the file for writing
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    // Split the line by comma and get the password (assuming it's at index 11)
                    string[] parts = line.Split(',');

                    string password = parts[11].Trim();

                    // Check if the password matches the one to delete
                    if (password != bxDelete.Text)
                    {
                        // If the password doesn't match, write the line back to the file
                        sw.WriteLine(line);
                    }
                    else
                    {
                        // If the password matches, mark as deleted
                        deleted = true;
                    }

                }
            }

            if (deleted)
            {
                MessageBox.Show("Patient with the specified password has been deleted.");
            }
            else
            {
                MessageBox.Show("No patient found with the specified password.");
            }
            DataTable table = new DataTable();
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            TablePatient.DataSource = table;


            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    string username = parts[10];
                    string password = parts[11];
                    table.Rows.Add(username, password);
                }
            }
        }
    }
}
            
        