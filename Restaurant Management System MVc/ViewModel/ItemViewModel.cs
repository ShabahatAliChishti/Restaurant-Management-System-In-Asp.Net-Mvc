using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Management_System_MVc.ViewModel
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public Nullable<decimal> ItemPrice { get; set; }

    }
}