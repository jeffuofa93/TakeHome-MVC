using System.Collections.Generic;
using System.Data;

namespace TakeHome_MVC.Models
{
    /// <summary>
    /// class: CustomerViewModel
    /// This class provides the model for an individual customer and their orders. The most difficult method in this
    /// class is the DoPivot. See method description 
    /// </summary>
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

        /// <summary>
        /// method: DoPivot
        /// This method takes the list of CustomerOrder objects and converts it to a DataTable that can be used in the
        /// view. The method creates a column for each field in the objects and then iterates over each object and
        /// creates a row containing all field values for that object then adds the row to the DataTable.  
        /// </summary>
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