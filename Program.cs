using System.Runtime.CompilerServices;

namespace Hospital_Managment_System_OOP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login_Page());
        }

        class userData
        {
            protected string firstName;
            protected string lastName;
            protected int userID;
            protected string password;

            public userData(string firstName, string lastName, int userID, string password)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.userID = userID;
                this.password = password;
            }
          

        }
        class Patient :userData
        {
            int age;
            int phone;
            int PHN; //Personal Health Number
            int postalCode;
            string country;
            string address;
            string city;

            public Patient(string firstName, string lastName,int age,int phone,int PHN,int postalCode,string country,string address, string city, int userID,string password) :base(firstName,lastName,userID,password)
            {
                this.age = age;
                this.phone = phone;
                this.PHN = PHN;
                this.postalCode = postalCode;
                this.country = country;
                this.address = address;
                this.city = city;
            }           
        }
        class FrontDesk:userData
        {
            public FrontDesk(string firstName,string lastName, int userID, string password):base( firstName, lastName, userID,  password)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.userID=userID;
                this.password = password;
            }
        }
        class Admin : userData
        {

            public Admin(string firstName, string lastName, int userID, string password):base(firstName, lastName, userID, password)
            {
                this.firstName=firstName;
                this.lastName=lastName;
                this.userID=userID;
                this.password = password;
            }
        }
    }
}