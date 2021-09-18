using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace TakeHome_MVC.Models
{
    /// <summary>
    /// class: CustomerOrder
    /// This class is the model for individual orders. 
    /// </summary>
    public class CustomerOrder
    {
        public int OrderId { get; init; }
        public DateTime OrderDate { get; init; }
        public string Description { get; init; }
        public decimal Total { get; init; }

        public CustomerOrder(int orderId, DateTime orderDate, string description, decimal total)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            Description = description;
            Total = total;
        }


    }
}