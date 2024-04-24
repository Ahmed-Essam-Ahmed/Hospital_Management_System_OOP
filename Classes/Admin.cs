using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital_Managment_System_OOP
{
    internal class Admin : UserData
    {
        public Admin(string firstName, string lastName, string UserName, string password) : base(firstName, lastName, UserName, password)
        {
        }

        public Admin(string UserName, string Password): base("", "", UserName, Password)
        {
            this.UserName= UserName;
            this.password= Password;
        }
        public Admin() : base("", "", "", "")
        {
         
        }
        public override void Register()
        {

            string[] lines = File.ReadAllLines("AdminData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[2] == UserName)
                {
                    MessageBox.Show("Username Taken");
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter("AdminData.txt", true))
            {
                writer.WriteLine($"{firstName}|{lastName}|{UserName}|{password}");
            }

            MessageBox.Show("Registration Successful!");
        }

        public override bool Login()
        {
            string[] lines = File.ReadAllLines("AdminData.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Admin currentAdmin = new Admin(parts[0], parts[1], parts[2], parts[3]);
                if (parts[2] == UserName && parts[3] == password)
                {
                    return true;
                }
            }

            return false;
        }
        public void AddBeds()
        {
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length-1];
            string[] parts = lastLine.Split('|');
            string lastBedNumber= parts[1];

            int newBedNumber = int.Parse(lastBedNumber)+1;

            lines[lines.Length - 1] = $"{parts[0]}|{newBedNumber}";

            File.WriteAllLines("PatientPassAndBeds.txt", lines);

        }
        public void RemoveBeds()
        {
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split('|');
            string lastBedNumber = parts[1];

            int newBedNumber = int.Parse(lastBedNumber) - 1;

            lines[lines.Length - 1] = $"{parts[0]}|{newBedNumber}";

            File.WriteAllLines("PatientPassAndBeds.txt", lines);

        }
        public override void AllUsersAccounts(DataGridView dataGridView)
        {
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            dataGridView.DataSource = table;

            string filePath = "AdminData.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    string firstName= parts[0];
                    string lastName= parts[1];
                    string username = parts[2];
                    string password = parts[3];
                    table.Rows.Add(firstName,lastName,username, password);
                }
            }

        }
    }
    

}
