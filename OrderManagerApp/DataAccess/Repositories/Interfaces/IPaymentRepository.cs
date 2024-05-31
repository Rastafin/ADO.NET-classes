using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        decimal CalculateTotalAmountForOrder(int orderId);
        List<Payment> GetAllPayments();
        void AddPayment(Payment payment);
        List<int> GetPaymentIdsWithStatusWaiting();
        void SettlePayment(int paymentId, decimal amount);
        decimal GetMaxSettlementAmount(int paymentId);
        Payment GetPaymentById(int paymentId);
        void UpdatePayment(Payment payment);
    }
}
