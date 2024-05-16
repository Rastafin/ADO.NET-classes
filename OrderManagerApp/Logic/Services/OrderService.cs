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

        public void AddToOrder(Order order)
        {
            try
            {
                _orderRepository.AddToOrder(order);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in AddToOrder method. " + ex.Message);
            }
        }

        public void ChangeStatus(Order order)
        {
            try
            {
                _orderRepository.ChangeStatus(order);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in ChangeStatus method. " + ex.Message);
            }
        }

        public void DeleteOrder(int Id)
        {
            try
            {
               _orderRepository.DeleteOrder(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in DeleteOrder method. " + ex.Message);
            }
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                return _orderRepository.GetAllOrders();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetAllOrders method. " + ex.Message);
            }
        }

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
    }
}
