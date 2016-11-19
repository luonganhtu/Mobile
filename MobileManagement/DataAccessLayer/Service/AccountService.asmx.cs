using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataAccessLayer.Entitty;
using DataAccessLayer.DTO;
using DataAccessLayer.Utilities;

namespace DataAccessLayer.Service
{
    /// <summary>
    /// Summary description for AccountService
    /// </summary>
    [WebService(Namespace = "http://AccountService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AccountService : System.Web.Services.WebService
    {
        public AccountService() { }
        private MobileEntities db;

        [WebMethod]
        public bool CheckAccount(string pAccountName, string pPassword)
        {
            using (db = new MobileEntities())
            {
                var query = db.ACCOUNTs.SingleOrDefault(p => p.AccountName.Equals(pAccountName) && p.Password.Equals(pPassword) && p.Level == 1);
                if (query != null)
                {
                    return true;
                }
                else
                    return false;
            }
        }

    }
}
