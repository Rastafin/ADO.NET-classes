using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Payment(int orderId, decimal amount, DateTime paymentDate, PaymentStatus status)
    {
        public int Id { get; set; }
        public int OrderId { get; set; } = orderId;
        public decimal Amount { get; set; } = amount;
        public DateTime PaymentDate { get; set; } = paymentDate;
        public PaymentStatus Status { get; set; } = status;
    }
}
