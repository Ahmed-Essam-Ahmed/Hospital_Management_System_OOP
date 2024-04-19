using System;
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
       

        public string generatePatientPassword()
        {
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(',');
            string lastPassword = parts[0];

            int newPassword = int.Parse(lastPassword) + 1;

            lines[lines.Length - 1] = $"{newPassword},{parts[1]}";

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
    }
}
