using Microsoft.IdentityModel.Tokens;
using System;
using System.CodeDom.Compiler;
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
            Front_Desk_Dashboard front_Desk_Dashboard = new Front_Desk_Dashboard();
            front_Desk_Dashboard.Show();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bxFirstName.Text)  || string.IsNullOrEmpty(bxLastName.Text)||
                string.IsNullOrEmpty(bxPhoneNum.Text)|| string.IsNullOrEmpty(bxAge.Text) ||
                string.IsNullOrEmpty(bxPHN.Text) || string.IsNullOrEmpty(bxPostal.Text) ||
                string.IsNullOrEmpty(bxCountry.Text) || string.IsNullOrEmpty(bxAddress.Text) ||
                string.IsNullOrEmpty(bxCity.Text) || string.IsNullOrEmpty(bxDisease.Text))
            {
                MessageBox.Show("Complete All Fields!");
            }
            else {
                string firstName = bxFirstName.Text;
                string lastName = bxLastName.Text;
                string phoneNum = bxPhoneNum.Text;
                string age = bxAge.Text;
                string PHN = bxPHN.Text;
                string postal = bxPostal.Text;
                string country = bxCountry.Text;
                string address = bxAddress.Text;
                string city = bxCity.Text;
                string disease = bxDisease.Text;
                string password = string.Empty;
                //string country = bxCountry.SelectedItem.ToString();
                //string disease = bxDisease.SelectedItem.ToString();

                if(!IsValidName(firstName) || !IsValidName(lastName) || !IsValidName(city))
                {
                    MessageBox.Show("Invalid first name, last name, or city!");
                    return;
                }
                if (!IsValidNumber(phoneNum) || !IsValidNumber(age) || !IsValidNumber(PHN) || !IsValidNumber(postal))
                {
                    MessageBox.Show("Invalid phone number, age, PHN, or postal code!");
                    return;
                }

                    Patient currentPatient = new Patient(firstName, lastName, age, phoneNum, PHN,
                    postal, country, address, city, firstName + lastName, password);

                string assignedPassword = currentPatient.generatePatientPassword();

                using (StreamWriter writer = new StreamWriter("PatientData.txt", true))

                    writer.WriteLine($"{firstName}|{lastName}|{phoneNum}|{age}|{PHN}|{postal}|{country}|{address}|" +
                        $"{city}|{disease}|{firstName + '_' + lastName}|{assignedPassword}");


                MessageBox.Show($"Registration Successful!\nUsername:{firstName + '_' + lastName} \nPassword:{assignedPassword}");
                bxFirstName.Text = string.Empty;
                bxLastName.Text = string.Empty;
                bxPhoneNum.Text = string.Empty;
                bxAge.Text = string.Empty;
                bxCountry.Text = string.Empty;
                bxAddress.Text = string.Empty;
                bxCity.Text = string.Empty;
                bxPHN.Text = string.Empty;
                bxPostal.Text = string.Empty;
                bxDisease.Text = string.Empty;
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private bool IsValidName(string name)
        {
            foreach (char c in name)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == ' '))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsValidNumber(string number)
        {
            foreach (char c in number)
                if (!char.IsDigit(c))
                    return false;
            return true;
        }

    }
}
