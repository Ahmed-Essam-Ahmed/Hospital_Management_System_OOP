using System;
using System.Collections.Generic;
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
    }
}
