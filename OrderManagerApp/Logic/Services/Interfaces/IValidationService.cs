using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services.Interfaces
{
    public interface IValidationService
    {
        public bool ValidateCustomerAddOrEditProcess(string firstName, string lastName, string newEmail, out string message, string existingEmail = "");
    }
}
