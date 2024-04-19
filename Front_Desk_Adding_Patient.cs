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
            string firstName = bxFirstName.Text;
            string lastName = bxLastName.Text;
            string phoneNum=bxPhoneNum.Text;
            string age=bxAge.Text;
            string PHN = bxPHN.Text;
            string postal = bxPostal.Text;
            string country = bxCountry.SelectedItem.ToString();
            string address = bxAddress.Text;
            string city = bxCity.Text;
            string disease = bxDisease.SelectedItem.ToString();
            string password = string.Empty;
            
            Patient currentPatient = new Patient(firstName, lastName, age, phoneNum, PHN,
                postal, country, address, city, firstName+lastName,password);

            string assignedPassword=currentPatient.generatePatientPassword();

            using (StreamWriter writer = new StreamWriter("PatientData.txt", true))
            
                writer.WriteLine($"{firstName},{lastName},{phoneNum},{age},{PHN},{postal},{country},{address}," +
                    $"{city},{disease},{firstName+'_'+lastName},{assignedPassword}");
            

            MessageBox.Show($"Registration Successful!\nUsername:{firstName+'_'+lastName} \nPassword:{assignedPassword}");

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
