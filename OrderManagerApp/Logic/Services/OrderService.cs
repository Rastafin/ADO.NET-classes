using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class OrderService() : IOrderService
    {
        private readonly IOrderRepository _orderRepository = new OrderRepository();

        public List<int> GetMissingOrderIdsInPayments()
        {
            try
            {
                return _orderRepository.GetMissingOrderIdsInPayments();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetMissingOrderIdsInPayments method. " + ex.Message);
            }
        }

        public Order GetOrderByPaymentId(int paymentId)
        {
            try
            {
                return _orderRepository.GetOrderByPaymentId(paymentId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetOrderByPaymentId method. " + ex.Message);
            }
        }
    }
}
