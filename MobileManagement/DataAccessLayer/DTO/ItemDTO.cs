using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ram { get; set; }
        public string Pin { get; set; }
        public string Camera { get; set; }
        public string Cpu { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public ItemDTO() { }
    }
}