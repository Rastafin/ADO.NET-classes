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
    public class PaymentService() : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository = new PaymentRepository();

        public void AddPayment(Payment payment)
        {
            try
            {
                _paymentRepository.AddPayment(payment);
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred in AddPayment method. " + ex.Message);
            }
        }

        public List<Payment> GetAllPayments()
        {
            try
            {
                return _paymentRepository.GetAllPayments();
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred in GetAllPayments method. " + ex.Message);
            }
        }
    }
}
