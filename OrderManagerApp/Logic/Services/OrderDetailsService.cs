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
        private readonly IProductRepository _productRepository = new ProductRepository();

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                _orderDetailsRepository.AddOrderDetails(orderDetails);

                Product product = _productRepository.GetProduct(orderDetails.ProductId);
                product.StockQuantity -= orderDetails.Quantity;
                _productRepository.UpdateProduct(product);
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
                OrderDetails orderDetails = _orderDetailsRepository.GetOrderDetails(orderDetailsId);
                Product product = (_productRepository.GetProduct(orderDetails.ProductId));
                product.StockQuantity += orderDetails.Quantity;
                _productRepository.UpdateProduct(product);

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
