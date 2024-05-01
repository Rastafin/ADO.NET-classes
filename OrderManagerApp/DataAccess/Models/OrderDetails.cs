using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderDetails(int orderId, int productId, int quantity)
    {
        public int Id { get; set; }
        public int OrderId { get; set; } = orderId;
        public int ProductId { get; set; } = productId;
        public int Quantity { get; set; } = quantity;
    }
}
