using DataAccess.Models;
using Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class ValidationService : IValidationService
    {
        private readonly ICustomerService _customerService = new CustomerService();

        public bool ValidateCustomerAddOrEditProcess(string firstName, string lastName, string newEmail, out string message, string existingEmail = "")
        {
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(newEmail))
            {
                message = "Not every form field is filled.";
                return false;
            }

            if(firstName.Length > 100)
            {
                message = "Name field is too long.";
                return false;
            }

            if (lastName.Length > 100)
            {
                message = "Last name field is too long.";
                return false;
            }

            if (newEmail.Length > 255)
            {
                message = "Email field is too long.";
                return false;
            }

            if (!isEmailValid(newEmail))
            {
                message = "Invalid email format.";
                return false;
            }

            if(!isEmailUnique(newEmail, existingEmail))
            {
                message = "Such an email already exists.";
                return false;
            }

            message = string.Empty;
            return true;
        }

        private bool isEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private bool isEmailUnique(string newEmail, string existingEmail)
        {
            try
            {
                if(newEmail != existingEmail)
                {
                    return !_customerService.GetAllCustomers().Any(customer => customer.Email == newEmail);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
