using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.SecurityOperations.Abstract;
using W06.SecurityOperations.Abstract;

namespace W06.Business
{
    public class SecurityService
    {
        private readonly ISecurityService _securityService;
        public SecurityService(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        public bool Login(string username, string password)
        {
            return _securityService.AuthenticateUser(username, password);
        }

        public bool Authorize(string username, string password)
        {
            return _securityService.AuthorizeUser(username, password);
        }
    }
}