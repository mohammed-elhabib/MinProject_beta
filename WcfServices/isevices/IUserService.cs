using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        string AddUser();

        [OperationContract]
        void EditUser();

        [OperationContract]
        void RemoveUser();

        [OperationContract]
        void GetAllUsers();

        [OperationContract]
        void SerchForUsers();

    }
}
