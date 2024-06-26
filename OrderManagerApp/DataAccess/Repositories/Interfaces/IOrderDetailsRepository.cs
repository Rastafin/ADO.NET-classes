﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IOrderDetailsRepository
    {
        void AddOrderDetails(OrderDetails orderDetails);
        List<OrderDetails> GetOrderDetailsForOrder(int orderId);
        void DeleteOrderDetails(int orderDetailsId);
        OrderDetails GetOrderDetails(int orderDetailsId);
    }
}
