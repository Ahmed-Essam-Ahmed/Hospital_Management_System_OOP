using System;
using System.Data;
using System.IO;

namespace Hospital_Managment_System_OOP
{
    internal class Patient : UserData
    {
        string age;
        string phone;
        string PHN; //Personal Health Number
        string postalCode;
        string country;
        string address;
        string city;

        public Patient(string firstName, string lastName, string age, string phone, string PHN, string postalCode, string country,
            string address, string city, string UserName, string password) : base(firstName, lastName, UserName, password)
        {
            this.age = age;
            this.phone = phone;
            this.PHN = PHN;
            this.postalCode = postalCode;
            this.country = country;
            this.address = address;
            this.city = city;
        }

        public Patient() : base("", "", "", "")
        {

        }



        public string generatePatientPassword()
        {
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split('|');
            string lastPassword = parts[0];

            int newPassword = int.Parse(lastPassword) + 1;

            lines[lines.Length - 1] = $"{newPassword}|{parts[1]}";

            File.WriteAllLines("PatientPassAndBeds.txt", lines);

            return lastPassword;
        }

        public override void Register()
        {
            throw new NotImplementedException();
        }

        public override bool Login()
        {
            throw new NotImplementedException();
        }
        public override void AllUsersAccounts(DataGridView dataGridView)
        {
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));
            table.Columns.Add("Age", typeof(string));
            table.Columns.Add("PHN", typeof(string));
            table.Columns.Add("Postal Code", typeof(string));
            table.Columns.Add("Country", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Disease", typeof(string));
            dataGridView.DataSource = table;

            string filePath = "PatientData.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    string firstName = parts[0];
                    string lastName = parts[1];
                    string PhoneNum = parts[2];
                    string Age = parts[3];
                    string PHN = parts[4];
                    string postalCode = parts[5];
                    string country = parts[6];
                    string address = parts[7];
                    string city = parts[8];
                    string disease = parts[9];
                    string username= parts[10];
                    string password= parts[11];
                    
                    table.Rows.Add(firstName, lastName, username, password, PhoneNum, Age, PHN, postalCode,country,address,city,disease);
                }
            }


        }
    }
}
