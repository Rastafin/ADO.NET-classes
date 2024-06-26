﻿using DataAccess.Models;
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

        public decimal CalculateTotalAmountForOrder(int orderId)
        {
            try
            {
                return _paymentRepository.CalculateTotalAmountForOrder(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in CalculateTotalAmountForOrder method. " + ex.Message);
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
                        PaymentId = payment.PaymentId,
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

        public decimal GetMaxSettlementAmount(int paymentId)
        {
            try
            {
                return _paymentRepository.GetMaxSettlementAmount(paymentId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetMaxSettlementAmount method. " + ex.Message);
            }
        }

        public Payment GetPaymentById(int paymentId)
        {
            try
            {
                return _paymentRepository.GetPaymentById(paymentId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetPaymentById method. " + ex.Message);
            }
        }

        public List<int> GetPaymentIdsWithStatusWiting()
        {
            try
            {
                return _paymentRepository.GetPaymentIdsWithStatusWaiting();
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

        public void UpdatePayment(Payment payment)
        {
            try
            {
                _paymentRepository.UpdatePayment(payment);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in UpdatePayment method. " + ex.Message);
            }
        }
    }
}
