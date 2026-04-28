using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public Users(string firstName, string lastName, string password)
        {
            firstName = FirstName;
            lastName = LastName;
            password = Password;
        }

    }
}
