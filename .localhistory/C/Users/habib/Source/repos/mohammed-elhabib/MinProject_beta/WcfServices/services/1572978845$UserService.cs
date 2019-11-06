using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    public class UserService : IUserService
    {
        public string AddUser()
        {
            return "all";
        }
        
        public void EditUser()
        {
        }

        public void GetAllUsers()
        {
        }

        public void RemoveUser()
        {
        }

        public void SerchForUsers()
        {
        }
    }
}
