using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_System_OOP
{
    internal class Patient : UserData
    {
        int age;
        int phone;
        int PHN; //Personal Health Number
        int postalCode;
        string country;
        string address;
        string city;

        public Patient(string firstName, string lastName, int age, int phone, int PHN, int postalCode, string country,
            string address, string city, string UserName, string password) : base(firstName, lastName,UserName, password)
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
}
