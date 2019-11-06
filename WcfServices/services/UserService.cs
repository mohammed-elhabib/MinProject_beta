using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServices.model;

namespace WcfServices
{
    public class UserService : IUserService
    {
        public string AddUser()
        {

            testEntities entities = new testEntities();

            entities.users.Add(new user() { name=12 });
            return "done";
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
