using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface IOrderDetailsService
    {
        void AddOrderDetails(OrderDetails orderDetails);
        List<OrderDetails> GetOrderDetailsForOrder(int orderId);
        void DeleteOrderDetails(int orderDetailsId);
    }
}
