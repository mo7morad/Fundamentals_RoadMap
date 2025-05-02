using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsUser : clsPerson
    {
        public int UserID { get; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public clsUser(int personID, string userName, string password, bool isActive)
        {
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }
    }
}
