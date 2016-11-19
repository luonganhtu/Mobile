using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DTO
{
    public class RuleDTO
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }

        public RuleDTO() { }
    }
}