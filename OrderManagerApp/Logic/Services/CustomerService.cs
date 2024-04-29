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
            return _customerRepository.GetAllCustomers();
        }
    }
}
