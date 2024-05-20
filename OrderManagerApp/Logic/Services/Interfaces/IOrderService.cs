using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface IOrderService
    {
        List<int> GetMissingOrderIdsInPayments();
        public List<Order> GetAllOrders();
        public void ChangeStatus(Order order);
        Order GetOrderByPaymentId(int paymentId);
        public void AddToOrder(Order order);
        public void DeleteOrder(int Id);
        
        

    }
}
