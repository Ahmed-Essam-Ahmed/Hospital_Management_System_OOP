using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System_OOP
{
    internal class FrontDesk : UserData
    {
         public FrontDesk(string firstName, string lastName ,string UserName, string password) : base(firstName, lastName,UserName, password)
         {

         }
        public FrontDesk() : base("", "", "", "")
        {

        }

        public FrontDesk(string UserName, string Password) : base("", "", UserName, Password)
        {
            this.UserName = UserName;
            this.password = Password;
        }

        public override void Register()
        {
            string[] lines = File.ReadAllLines("Front_DeskData.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[2] == UserName)
                {
                    MessageBox.Show("Username Taken");
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter("Front_DeskData.txt", true))
            {
                writer.WriteLine($"{firstName}|{lastName}|{UserName}|{password}");
            }

            MessageBox.Show("Registration Successful!");
        }

        public override bool Login()
        {
            string[] lines = File.ReadAllLines("Front_DeskData.txt");

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
        public override void AllUsersAccounts(DataGridView dataGridView)
        {
            DataTable table = new DataTable();
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
            dataGridView.DataSource = table;

            string filePath = "Front_DeskData.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    string firstName = parts[0];
                    string lastName = parts[1];
                    string username = parts[2];
                    string password = parts[3];
                    table.Rows.Add(firstName, lastName, username, password);
                }
            }

        }
    }
}
