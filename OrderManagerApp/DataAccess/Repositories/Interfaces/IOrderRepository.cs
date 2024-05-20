using DataAccess.Models;
using DataAccess.Models.Enums;
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
        public int AddOrder(Order order);
        public void DeleteOrder(int Id);
        public void ChangeStatus(int orderId, OrderStatus orderStatus);

        Order GetOrderByPaymentId(int paymentId);
        Order GetOrderById(int orderId);
        List<int> GetOrdersToDeliverIds();
    }
}
