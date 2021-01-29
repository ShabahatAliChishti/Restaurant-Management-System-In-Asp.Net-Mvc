using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Management_System_MVc.ViewModel
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
        public int ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal Quantity { get; set; }

    }
}