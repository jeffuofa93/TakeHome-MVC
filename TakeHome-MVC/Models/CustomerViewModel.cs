using System.Collections.Generic;
using System.Data;

namespace TakeHome_MVC.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public List<CustomerOrder> Orders { get; set; }

        public DataTable PivotData { get; set; }

        public void DoPivot()
        {
            var dt = new DataTable();
            dt.Columns.Add("Order ID");
            dt.Columns.Add("Order Date");
            dt.Columns.Add("Item Description");
            dt.Columns.Add("Total");

            foreach (var item in this.Orders)
            {
                var dr = dt.NewRow();
                dr["Order ID"] = item.OrderId;
                dr["Order Date"] = item.OrderDate;
                dr["Item Description"] = item.Description;
                dr["Total"] = item.Total.ToString("C");
                dt.Rows.Add(dr);
            }

            this.PivotData = dt;
        }
    }
}