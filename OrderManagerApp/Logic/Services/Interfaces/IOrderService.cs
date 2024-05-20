using DataAccess.Models;
using DataAccess.Models.Enums;
using Shared.ViewModels;
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
        public void ChangeStatus(int orderId, OrderStatus orderStatus);
        Order GetOrderByPaymentId(int paymentId);
        public int AddOrder(Order order);
        public void DeleteOrder(int Id);
        public List<OrderViewModel> GetAllOrderViewModels();
        Order GetOrderById(int orderId);
        List<int> GetOrdersToDeliverIds();
    }
}
