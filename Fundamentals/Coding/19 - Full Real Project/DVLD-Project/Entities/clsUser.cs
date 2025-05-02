using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsUser : clsPerson
    {
        public int UserID { get; set; }
        public clsPerson PersonData { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser(clsPerson person, int userId, string username, string password, bool isActive)
        {
            UserID = userId;
            PersonData = person;
            UserName = username;
            Password = password;
            IsActive = isActive;
        }

        public clsUser(clsPerson person, string username, string password, bool isActive)
        {
            PersonData = person;
            UserName = username;
            Password = password;
            IsActive = isActive;
        }
    }
}
