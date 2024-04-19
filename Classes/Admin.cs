using System;
using System.Collections.Generic;
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
                string[] parts = line.Split(',');
                if (parts[2] == UserName)
                {
                    MessageBox.Show("Username Taken");
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter("AdminData.txt", true))
            {
                writer.WriteLine($"{firstName},{lastName},{UserName},{password}");
            }

            MessageBox.Show("Registration Successful!");
        }

        public override bool Login()
        {
            string[] lines = File.ReadAllLines("AdminData.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
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
            string[] parts = lastLine.Split(',');
            string lastBedNumber= parts[1];

            int newBedNumber = int.Parse(lastBedNumber)+1;

            lines[lines.Length - 1] = $"{parts[0]},{newBedNumber}";

            File.WriteAllLines("PatientPassAndBeds.txt", lines);

        }
        public void RemoveBeds()
        {
            string[] lines = File.ReadAllLines("PatientPassAndBeds.txt");

            string lastLine = lines[lines.Length - 1];
            string[] parts = lastLine.Split(',');
            string lastBedNumber = parts[1];

            int newBedNumber = int.Parse(lastBedNumber) - 1;

            lines[lines.Length - 1] = $"{parts[0]},{newBedNumber}";

            File.WriteAllLines("PatientPassAndBeds.txt", lines);

        }
    }
    

}
