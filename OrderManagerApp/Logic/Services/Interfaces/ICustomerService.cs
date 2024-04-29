﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
    }
}
