using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using TakeHome_MVC.Models;

namespace TakeHome_MVC.Controllers
{
    public class Customer : Controller
    {
        // GET
        public IActionResult Orders()
        {
            var customerViewModel = new CustomerViewModel
            {
                CustomerNumber = 1111,
                FirstName = "John",
                LastName = "Smith",
                FullName = "John Smith",
                Orders = new List<CustomerOrder>()
            };

            var order1 = new CustomerOrder()
            {
                OrderId = 1,
                OrderDate = DateTime.Now,
                Description = "Part1",
                Total = new decimal(10)
            };            
            
            var order2 = new CustomerOrder()
            {
                OrderId = 2,
                OrderDate = DateTime.Now,
                Description = "Part2",
                Total = new decimal(20)
            };            
            
            var order3 = new CustomerOrder()
            {
                OrderId = 3,
                OrderDate = DateTime.Now,
                Description = "Part3",
                Total = new decimal(30)
            };
            
            customerViewModel.Orders.Add(order1);
            customerViewModel.Orders.Add(order2);
            customerViewModel.Orders.Add(order3);
            customerViewModel.DoPivot();

            return View(customerViewModel);
        }

    }
}