using System;
using Microsoft.AspNetCore.Mvc;
using TakeHome_MVC.Models;

namespace TakeHome_MVC.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer : Controller
    {
        public IActionResult Orders()
        {
            var customerViewModel = new CustomerViewModel(customerNumber: 1111, firstName: "John", lastName: "Smith");
            var order1 = new CustomerOrder(orderId: 1, orderDate: DateTime.Now, description: "Part1",
                total: new decimal(10));
            var order2 = new CustomerOrder(orderId: 2, orderDate: DateTime.Now, description: "Part2",
                total: new decimal(20));
            var order3 = new CustomerOrder(orderId: 3, orderDate: DateTime.Now, description: "Part3",
                total: new decimal(30));
            
            customerViewModel.Orders.Add(order1);
            customerViewModel.Orders.Add(order2);
            customerViewModel.Orders.Add(order3);
            customerViewModel.DoPivot();
            return View(customerViewModel);
        }
    }
}