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
    public class CustomerService() : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public List<Customer> GetAllCustomers()
        {
            try
            {
                return _customerRepository.GetAllCustomers();
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred in GetAllCustomers method. " + ex.Message);
            }
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                _customerRepository.AddCustomer(customer);
            }
            catch(Exception ex)
            {
                throw new Exception("An error occurred in AddCustomer method. " + ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                _customerRepository.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in UpdateCustomer method. " + ex.Message);
            }
        }

        public void DeleteCustomer(int customerId)
        {
                _customerRepository.DeleteCustomer(customerId);
        }

        public Customer GetCustomerByOrderId(int orderId)
        {
            try
            {
                return _customerRepository.GetCustomerByOrderId(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred in GetCustomerByOrderId method. " + ex.Message);
            }
        }
    }
}
