using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public byte Level { get; set; }

        public AccountDTO() { }
    }
}