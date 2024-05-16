using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<int> GetMissingOrderIdsInPayments();
        public List<Order> GetAllOrders();
        public void AddToOrder(Order order);
        public void DeleteOrder(int Id);
        public void ChangeStatus(Order order);
        Order GetOrderByPaymentId(int paymentId);

    }
}
