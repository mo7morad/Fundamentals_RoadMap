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
        public bool Status { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public clsUser(int userID, bool status, string userName, string password)
        {
            UserID = userID;
            Status = status;
            UserName = userName;
            Password = password;
        }
    }
}
