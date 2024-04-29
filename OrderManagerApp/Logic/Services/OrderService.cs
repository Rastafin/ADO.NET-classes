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
    }
}
