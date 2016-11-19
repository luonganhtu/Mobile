using DataAccessLayer.Entitty;
using DataAccessLayer.DTO;
using DataAccessLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DataAccessLayer.Service
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://UserService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {

        public UserService() { }
        private MobileEntities db;

        [WebMethod]
        public List<UserDTO> GetListUser()
        {
            using (db = new MobileEntities())
            {
                return DALUtilitiesMethod.UserDTOList(db.USERs.ToList());
            }
        }

       
    }
}
