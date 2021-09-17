using System.Data;

namespace TakeHome_MVC.Models
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }
        public DataSetDateTime OrderDate { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        
    }
}