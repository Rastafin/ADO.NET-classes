using DataAccess.Models;
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
<<<<<<< HEAD
        public List<Order> GetAllOrders();
        public void AddToOrder(Order order);
        public void DeleteOrder(int Id);
        public void ChangeStatus(Order order);
=======
        Order GetOrderByPaymentId(int paymentId);
>>>>>>> 14ca6cc35a687ffcde734456a6549fcb2cf8009a
    }
}
