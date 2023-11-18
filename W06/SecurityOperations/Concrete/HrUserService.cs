using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.SecurityOperations.Abstract;
using W06.SecurityOperations.Abstract;

namespace W06.SecurityOperations.Concrete
{
    public class HrUserService : ISecurityService
    {
        public bool AuthenticateUser(string username, string password)
        {
            //...
            throw new NotImplementedException();
        }

        public bool AuthorizeUser(string username, string permission)
        {
            //...
            throw new NotImplementedException();
        }
    }
}