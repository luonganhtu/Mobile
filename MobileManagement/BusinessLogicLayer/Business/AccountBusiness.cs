using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.AccountLocalhost;

namespace BusinessLogicLayer.Business
{
    public class AccountBusiness
    {
        private AccountService service;

        public AccountBusiness()
        {
            service = new AccountService();
        }

        public bool CheckAccount(string pAccountName, string pPassword)
        {
            return service.CheckAccount(pAccountName, pPassword);
        }
    }
}
