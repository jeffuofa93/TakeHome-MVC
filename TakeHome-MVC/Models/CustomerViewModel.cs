using System.Collections.Generic;
using System.Data;

namespace TakeHome_MVC.Models
{
    public class CustomerViewModel
    {
        
        public int CustomerNumber { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        
        public string FullName { get; }

        public List<CustomerOrder> Orders { get; set; }
        public DataTable PivotData { get; private set; }

        public CustomerViewModel(int customerNumber, string firstName, string lastName)
        {
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Orders = new List<CustomerOrder>();
            FullName = firstName + " " + lastName;
        }

        public void DoPivot()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Order ID");
            dataTable.Columns.Add("Order Date");
            dataTable.Columns.Add("Item Description");
            dataTable.Columns.Add("Total");

            foreach (var item in Orders)
            {
                var dataRow = dataTable.NewRow();
                dataRow["Order ID"] = item.OrderId;
                dataRow["Order Date"] = item.OrderDate;
                dataRow["Item Description"] = item.Description;
                dataRow["Total"] = item.Total.ToString("C");
                dataTable.Rows.Add(dataRow);
            }

            PivotData = dataTable;
        }
    }
}