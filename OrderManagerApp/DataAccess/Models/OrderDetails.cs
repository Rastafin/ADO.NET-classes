using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; } 
        public int ProductId { get; set; } 
        public int Quantity { get; set; }

        public OrderDetails(int id, int orderId, int productId, int quantity)
        {
            OrderDetailsId = id;
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
        public OrderDetails( int orderId, int productId, int quantity)
        {
            
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
