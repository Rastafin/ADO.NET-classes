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
    }
}
