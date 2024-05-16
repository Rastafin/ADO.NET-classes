using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } 
        public DateTime OrderDate { get; set; } 
        public OrderStatus Status { get; set; }

        public Order(int id, int customerId, DateTime orderDate, OrderStatus status)
        {
            Id = id;
            CustomerId = customerId;
            OrderDate = orderDate;
            Status = status;
        }

        public Order(int customerId, DateTime orderDate, OrderStatus status)
        {
            CustomerId = customerId;
            OrderDate = orderDate;
            Status = status;
        }
    }
}
