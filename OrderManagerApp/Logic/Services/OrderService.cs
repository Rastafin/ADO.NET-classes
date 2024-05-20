using DataAccess.Models;
using DataAccess.Models.Enums;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Logic.Services.Interfaces;
using Shared.ViewModels;
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
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public int AddOrder(Order order)
        {
            try
            {
                return _orderRepository.AddOrder(order);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in AddToOrder method. " + ex.Message);
            }
        }

        public void ChangeStatus(int orderId, OrderStatus orderStatus)
        {
            try
            {
                _orderRepository.ChangeStatus(orderId, orderStatus);
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

        public List<OrderViewModel> GetAllOrderViewModels()
        {
            try
            {
                List<Order> orders = _orderRepository.GetAllOrders();

                List<OrderViewModel> orderViewModels = new List<OrderViewModel>();

                foreach (Order order in orders)
                {
                    Customer customer = _customerRepository.GetCustomerByOrderId(order.Id);

                    OrderViewModel orderViewModel = new OrderViewModel
                    {
                        Id = order.Id,
                        CustomerName = customer.FirstName + " " + customer.LastName,
                        OrderDate = order.OrderDate,
                        Status = order.Status
                    };

                    orderViewModels.Add(orderViewModel);
                }

                return orderViewModels;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetAllOrderViewModels method. " + ex.Message);
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

        public Order GetOrderById(int orderId)
        {
            try
            {
                return _orderRepository.GetOrderById(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetOrderById method. " + ex.Message);
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

        public List<int> GetOrdersToDeliverIds()
        {
            try
            {
                return _orderRepository.GetOrdersToDeliverIds();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetOrdersToDeliverIds method. " + ex.Message);
            }
        }
    }
}
