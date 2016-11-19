using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DTO
{
    public class OrderDetailDTO
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double PriceOrder { get; set; }

        public OrderDetailDTO() { }
    }
}