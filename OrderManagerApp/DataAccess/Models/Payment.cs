using DataAccess.Models.Enums;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentStatus Status { get; set; }

        private readonly IPaymentRepository _paymentRepository = new PaymentRepository();

        public Payment(int orderId, DateTime paymentDate, PaymentStatus status)
        {
            OrderId = orderId;
            PaymentDate = paymentDate;
            Status = status;

            Amount = _paymentRepository.CalculateTotalAmountForOrder(OrderId);
        }

        public Payment(int id, int orderId, decimal amount, DateTime paymentDate, PaymentStatus status)
        {
            PaymentId = id;
            OrderId = orderId;
            Amount = amount;
            PaymentDate = paymentDate;
            Status = status;
        }
    }
}
