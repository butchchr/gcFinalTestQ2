using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTestQ2.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }
        
        public DateTime? OrderDate { get; set; }
        
        public string ShipCity { get; set; }
    }
}