using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Interfaces;
using Logic.Services.Interfaces;
using Shared.ViewModels;
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
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

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

        public List<PaymentViewModel> GetAllPaymentsViewModel()
        {
            try
            {
                List<Payment> payments = _paymentRepository.GetAllPayments();

                List<PaymentViewModel> paymentsViewModel = new List<PaymentViewModel>();

                foreach (Payment payment in payments)
                {
                    Customer customer = _customerRepository.GetCustomerByOrderId(payment.OrderId);

                    PaymentViewModel paymentViewModel = new PaymentViewModel
                    {
                        Id = payment.Id,
                        Amount = payment.Amount,
                        PaymentDate = payment.PaymentDate,
                        Status = payment.Status,
                        CustomerName = customer.FirstName + " " + customer.LastName
                    };

                    paymentsViewModel.Add(paymentViewModel);
                }

                return paymentsViewModel;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetAllPaymentsViewModel method. " + ex.Message);
            }
        }

        public List<int> GetPaymentIdsWithStatusWiting()
        {
            try
            {
                return _paymentRepository.GetPaymentIdsWithStatusWiting();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetPaymentIdsWithStatusWiting method. " + ex.Message);
            }
        }

        public void SettlePayment(int paymentId, decimal amount)
        {
            try
            {
                _paymentRepository.SettlePayment(paymentId, amount);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in SettlePayment method. " + ex.Message);
            }
        }
    }
}
