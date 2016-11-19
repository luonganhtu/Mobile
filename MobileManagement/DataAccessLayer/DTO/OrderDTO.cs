using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int UserId { get; set; }

        public OrderDTO() { }
    }
}