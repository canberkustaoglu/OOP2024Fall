using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06.SecurityOperations.Abstract
{
    public interface ISecurityService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string permission);
    }
}