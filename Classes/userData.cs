using System;
using System.IO;
using System.Text.Json;

namespace Hospital_Managment_System_OOP
{
    internal abstract class UserData
    {
        protected string firstName ;
        protected string lastName;
        protected string UserName;
        protected string password;

        public UserData(string firstName, string lastName,string UserName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.UserName = UserName;
            this.password = password;
        }

        public abstract void Register();
        public abstract bool Login();
        
        public virtual void AllUsersAccounts(DataGridView dataGridView)
        {

        }

        
            
        
    }
}
