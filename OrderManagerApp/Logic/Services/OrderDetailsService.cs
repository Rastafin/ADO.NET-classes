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
    public class OrderDetailsService() : IOrderDetailsService
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository = new OrderDetailsRepository();

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                _orderDetailsRepository.AddOrderDetails(orderDetails);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in AddOrderDetails method. " + ex.Message);
            }
        }

        public void DeleteOrderDetails(int orderDetailsId)
        {
            try
            {
                _orderDetailsRepository.DeleteOrderDetails(orderDetailsId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in DeleteOrderDetails method. " + ex.Message);
            }
        }

        public List<OrderDetails> GetOrderDetailsForOrder(int orderId)
        {
            try
            {
                return _orderDetailsRepository.GetOrderDetailsForOrder(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetOrderDetailsForOrder method. " + ex.Message);
            }
        }
    }
}
