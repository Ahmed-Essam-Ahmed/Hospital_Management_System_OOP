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
    public partial class Patient_FollowUp : Form
    {
        public Patient_FollowUp()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page login_Page = new Login_Page();
            login_Page.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Dashboard patient_Dashboard = new Patient_Dashboard();
            patient_Dashboard.Show();
        }

        private void Patient_FollowUp_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("PatientData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[11] == CurrentUser.Password)
                {
                    CurrentUser.disease = parts[9];


                }


            }
            string[] data = File.ReadAllLines("DiseaseData.txt");
            foreach (string line in data)
            {
                string[] parts = line.Split('|');
                if (parts[0] == CurrentUser.disease)
                {
                    lblDisease.Text = parts[0];
                    lblSymptoms.Text = parts[1];
                    lblMedicine.Text = parts[2];
                    lblDose.Text = parts[3];
                }
            }
        }
    }
}
