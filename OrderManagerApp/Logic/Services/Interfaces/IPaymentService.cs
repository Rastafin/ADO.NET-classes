using DataAccess.Models;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface IPaymentService
    {
        List<Payment> GetAllPayments();
        void AddPayment(Payment payment);
        List<PaymentViewModel> GetAllPaymentsViewModel();
        List<int> GetPaymentIdsWithStatusWiting();
        void SettlePayment(int paymentId, decimal amount);
        decimal GetMaxSettlementAmount(int paymentId);
        Payment GetPaymentById(int paymentId);
        void UpdatePayment(Payment payment);
        decimal CalculateTotalAmountForOrder(int orderId);
    }
}
