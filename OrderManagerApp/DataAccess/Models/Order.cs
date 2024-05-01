using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Order(int customerId, DateTime orderDate, OrderStatus status)
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } = customerId;
        public DateTime OrderDate { get; set; } = orderDate;
        public OrderStatus Status { get; set; } = status;
    }
}
