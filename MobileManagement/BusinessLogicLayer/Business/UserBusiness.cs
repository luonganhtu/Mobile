using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.UserLocalhost;

namespace BusinessLogicLayer.Business
{
    public class UserBusiness
    {
        private UserService service;

        public UserBusiness()
        {
            service = new UserService();
        }

        public List<UserDTO> GetUserList()
        {
            return service.GetListUser().OrderBy(n=>n.FullName).ToList();
        }
    }
}
