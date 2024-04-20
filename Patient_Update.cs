using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Managment_System_OOP
{
    public partial class Patient_Update : Form
    {


        public Patient_Update()
        {

            InitializeComponent();
            //// Read the user's data from the text file
            //string[] lines = File.ReadAllLines("userdata.txt");
            //foreach (string line in lines)
            //{
            //    string[] parts = line.Split(',');
            //if (parts[10] == ) // Assuming username is at index 10
            //{
            //    // Populate TextBoxes with existing data

            //    bxPhone.Text = parts[2];
            //    bxAddress.Text = parts[7];
            //    bxAge.Text = parts[3];
            //    bxCity.Text = parts[8];
            //    bxCountry.SelectedItem = parts[6];
            //    bxPHN.Text = parts[4];
            //    bxPostal.Text = parts[5];
            //    break;
            //}
            //}




        }


        private void Patient_Update_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("PatientData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts[11] == CurrentUser.Password)
                {
                    CurrentUser.FirstName = parts[0];
                    CurrentUser.LastName = parts[1];
                    CurrentUser.phone = parts[2];
                    CurrentUser.age = parts[3];
                    CurrentUser.PHN = parts[4];
                    CurrentUser.postalCode = parts[5];
                    CurrentUser.country = parts[6];
                    CurrentUser.address = parts[7];
                    CurrentUser.city = parts[8];
                    CurrentUser.disease = parts[9];
                    CurrentUser.UserName = parts[10];
                    CurrentUser.Password = parts[11];

                    bxFirst.Text = CurrentUser.FirstName;
                    bxLast.Text = CurrentUser.LastName;
                    bxAge.Text = CurrentUser.age;
                    bxPhone.Text = CurrentUser.phone;
                    bxPostal.Text = CurrentUser.postalCode;
                    bxPHN.Text = CurrentUser.PHN;
                    bxCountry.Text = CurrentUser.country;
                    bxAddress.Text = CurrentUser.address;
                    bxCity.Text = CurrentUser.city;
                    bxDisease.Text = CurrentUser.disease;
                    bxUserName.Text = CurrentUser.UserName;
                    bxPassword.Text = CurrentUser.Password;


                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("PatientData.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(',');
            parts[0]=bxFirst.Text;
            parts[1]=bxLast.Text;
            parts[2] = bxPhone.Text; 
            parts[3]=bxAge.Text;
            parts[4]=bxPHN.Text;
            parts[5]=bxPostal.Text;
            parts[6]=bxCountry.Text;
            parts[7]=bxAddress.Text;
            parts[8] = bxCity.Text;
            parts[9] = bxDisease.Text;
            parts[10] = bxUserName.Text;
            parts[11] = bxPassword.Text;



      
            lines[lines.Length - 1] = $"{parts[0]},{parts[1]},{parts[2]}," +
                $"{parts[3]},{parts[4]},{parts[5]},{parts[6]},{parts[7]}," +
                $"{parts[8]},{parts[9]},{parts[10]},{parts[11]}";

            File.WriteAllLines("PatientData.txt", lines);
            MessageBox.Show("Info Updated Successfully");

        }
       
    }
}
