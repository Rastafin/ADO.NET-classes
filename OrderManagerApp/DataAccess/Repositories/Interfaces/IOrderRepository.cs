using DataAccess.Models;
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
        Order GetOrderByPaymentId(int paymentId);
    }
}
