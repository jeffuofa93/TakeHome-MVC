using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TakeHome_MVC.Models
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        

        
    }
}